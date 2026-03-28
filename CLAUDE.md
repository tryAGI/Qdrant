# CLAUDE.md -- Qdrant SDK

## Overview

Auto-generated C# SDK for [Qdrant](https://qdrant.tech/) -- open-source vector search engine with collections, points, indexes, search, snapshots, aliases, distributed clustering, and service management.
OpenAPI spec from the official [qdrant/qdrant](https://github.com/qdrant/qdrant) repo.

## Build & Test

```bash
dotnet build Qdrant.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (converted to `api-key` header at request time):

```csharp
var client = new QdrantClient(apiKey); // QDRANT_API_KEY env var
```

Default base URL: `http://localhost:6333` (local Qdrant instance).

**Important:** Qdrant uses an `api-key` header instead of `Authorization: Bearer`. The SDK accepts the key as a Bearer token and `PrepareRequest` converts it to the `api-key` header automatically:

```csharp
// In Extensions/QdrantClient.Auth.cs
partial void PrepareRequest(HttpClient client, HttpRequestMessage request)
{
    if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } apiKey })
    {
        request.Headers.Authorization = null;
        request.Headers.TryAddWithoutValidation("api-key", apiKey);
    }
}
```

This `PrepareRequest` pattern is also used by other SDKs with non-standard auth headers (Deepgram `Token`, BraveSearch `X-Subscription-Token`, Serper `X-API-KEY`, DeepL `DeepL-Auth-Key`).

> **Alternative:** Could use `--security-scheme ApiKey:Header:api-key` CLI arg instead of the jq auth conversion + PrepareRequest hook.

## Key Files

- `src/libs/Qdrant/openapi.json` -- OpenAPI spec (downloaded from qdrant/qdrant repo)
- `src/libs/Qdrant/generate.sh` -- Downloads spec, replaces auth with http/bearer, simplifies servers, renames colliding schemas, runs autosdk
- `src/libs/Qdrant/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Qdrant/Extensions/QdrantClient.Auth.cs` -- Converts Bearer to `api-key` header
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

The `generate.sh` applies several fixes via `jq`:

1. **Auth conversion:** Replaces `apiKey` security scheme with `http/bearer` and adds top-level `security` array
2. **Server simplification:** Replaces template-based server URLs with plain `http://localhost:6333` (AutoSDK does not support server URL templates)
3. **Schema renames to avoid collisions:**
   - `Disabled` -> `DisabledType` (single-value enum where value matches type name generates empty identifier)
   - `Snowball` -> `SnowballType` (same issue)
   - `Match` -> `MatchCondition` (member name collides with type name, CS0542)
4. All `$ref` pointers are updated via `walk()` to reflect the renamed schemas

Uses `--exclude-deprecated-operations` flag.

## Sub-client Pattern

Qdrant API has tagged operations generating sub-clients:
- `client.Collections.*` -- Create, get, list, update, delete collections; check existence; get load state, stats, optimizations
- `client.Points.*` -- Upsert, get, scroll, delete, count points; set/clear/delete payload; update/delete vectors; batch update; facet
- `client.Search.*` -- Query points, query batch, query groups; search matrix (offsets/pairs)
- `client.Indexes.*` -- Create and delete field indexes
- `client.Snapshots.*` -- Create, list, get, delete, recover snapshots (collection, shard, full)
- `client.Aliases.*` -- Get, list, update collection aliases
- `client.Distributed.*` -- Cluster status, telemetry, collection cluster info; shard key management; peer management
- `client.Service.*` -- Health checks (healthz, livez, readyz), metrics, telemetry, root info
- `client.Beta.*` -- Get and clear issues (beta features)

## MEAI Integration

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented -- Qdrant is a vector database with no matching MEAI interface.
