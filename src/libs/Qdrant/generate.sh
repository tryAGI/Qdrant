#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://raw.githubusercontent.com/qdrant/qdrant/master/docs/redoc/master/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.json https://raw.githubusercontent.com/qdrant/qdrant/master/docs/redoc/master/openapi.json

# Fix 1: Simplify servers (template variables not supported by AutoSDK).
# Fix 2: Schema renames to avoid collisions:
#         - Disabled → DisabledType, Snowball → SnowballType (single-value enum generates empty identifier)
#         - Match → MatchCondition (member name collides with type name, CS0542)
# Fix 3: Update all $ref pointers for renamed schemas via walk().
jq '
  # Fix 1: server simplification
  .servers = [{"url": "http://localhost:6333"}] |

  # Fix 2: schema renames
  .components.schemas.DisabledType = .components.schemas.Disabled |
  del(.components.schemas.Disabled) |
  .components.schemas.SnowballType = .components.schemas.Snowball |
  del(.components.schemas.Snowball) |
  .components.schemas.MatchCondition = .components.schemas.Match |
  del(.components.schemas.Match) |

  # Fix 3: update $ref pointers
  walk(if type == "object" and .["$ref"] == "#/components/schemas/Disabled" then .["$ref"] = "#/components/schemas/DisabledType" elif type == "object" and .["$ref"] == "#/components/schemas/Snowball" then .["$ref"] = "#/components/schemas/SnowballType" elif type == "object" and .["$ref"] == "#/components/schemas/Match" then .["$ref"] = "#/components/schemas/MatchCondition" else . end) |

  # Fix 4: `GET /telemetry` declares container_runtime required, and a running server does not
  # send it - found against the Testcontainers instance, where the whole telemetry tree failed to
  # deserialize a successful HTTP 200.
  .components.schemas.RunningEnvironmentTelemetry.required |= map(select(. != "container_runtime"))
' openapi.json > openapi.fixed.json
mv openapi.fixed.json openapi.json

# jq is not in-place and a failed filter would leave the spec untouched, so verify the effect.
if jq -e '.components.schemas.RunningEnvironmentTelemetry.required | index("container_runtime")' openapi.json >/dev/null 2>&1; then
  echo "error: the response-shape patch did not apply to openapi.json." >&2
  exit 1
fi

# Auth: --security-scheme sends the API key directly as api-key header
#       (no jq auth conversion or PrepareRequest hook needed).
autosdk generate openapi.json \
  --namespace Qdrant \
  --clientClassName QdrantClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:api-key
