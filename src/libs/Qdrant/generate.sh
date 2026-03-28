#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.json https://raw.githubusercontent.com/qdrant/qdrant/master/docs/redoc/master/openapi.json

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
  walk(if type == "object" and .["$ref"] == "#/components/schemas/Disabled" then .["$ref"] = "#/components/schemas/DisabledType" elif type == "object" and .["$ref"] == "#/components/schemas/Snowball" then .["$ref"] = "#/components/schemas/SnowballType" elif type == "object" and .["$ref"] == "#/components/schemas/Match" then .["$ref"] = "#/components/schemas/MatchCondition" else . end)
' openapi.json > openapi.fixed.json
mv openapi.fixed.json openapi.json

# Auth: --security-scheme sends the API key directly as api-key header
#       (no jq auth conversion or PrepareRequest hook needed).
autosdk generate openapi.json \
  --namespace Qdrant \
  --clientClassName QdrantClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:api-key
