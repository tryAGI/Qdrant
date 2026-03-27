dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.json https://raw.githubusercontent.com/qdrant/qdrant/master/docs/redoc/master/openapi.json

# Fix auth scheme: convert apiKey to http/bearer and simplify servers
jq '
  # Replace the api-key securityScheme with http/bearer
  .components.securitySchemes = {
    "bearerAuth": {
      "type": "http",
      "scheme": "bearer"
    }
  }
  # Replace security to only use bearerAuth
  | .security = [{"bearerAuth": []}]
  # Simplify servers to a plain URL (template variables not supported by AutoSDK)
  | .servers = [{"url": "http://localhost:6333"}]
  # Fix single-value enums where value matches type name (AutoSDK generates empty identifiers)
  # Rename schemas to avoid name collision: Disabled -> DisabledType, Snowball -> SnowballType
  | .components.schemas.DisabledType = .components.schemas.Disabled
  | del(.components.schemas.Disabled)
  | .components.schemas.SnowballType = .components.schemas.Snowball
  | del(.components.schemas.Snowball)
  # Update all references
  # Fix Match union type: member name collides with type name (CS0542)
  | .components.schemas.MatchCondition = .components.schemas.Match
  | del(.components.schemas.Match)
  # Update all $ref pointers
  | walk(if type == "object" and .["$ref"] == "#/components/schemas/Disabled" then .["$ref"] = "#/components/schemas/DisabledType" elif type == "object" and .["$ref"] == "#/components/schemas/Snowball" then .["$ref"] = "#/components/schemas/SnowballType" elif type == "object" and .["$ref"] == "#/components/schemas/Match" then .["$ref"] = "#/components/schemas/MatchCondition" else . end)
' openapi.json > openapi.fixed.json
mv openapi.fixed.json openapi.json

autosdk generate openapi.json \
  --namespace Qdrant \
  --clientClassName QdrantClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
