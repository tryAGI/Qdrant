# Authentication

The Qdrant SDK uses API key authentication. You can obtain an API key from your [Qdrant Cloud dashboard](https://cloud.qdrant.io/).

## Basic Usage

```csharp
using Qdrant;

var client = new QdrantClient(apiKey: Environment.GetEnvironmentVariable("QDRANT_API_KEY")!);
```

## How It Works

Qdrant natively uses the `api-key` header for authentication. The SDK automatically converts the Bearer token to the `api-key` header format via a `PrepareRequest` hook, so you just pass your API key to the constructor.

## Self-Hosted Instances

For self-hosted Qdrant instances, you can configure a custom base URL via `HttpClient`:

```csharp
using Qdrant;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("http://localhost:6333"),
};

var client = new QdrantClient(apiKey: "your-api-key", httpClient: httpClient);
```

If your self-hosted instance does not require authentication, you can pass an empty string as the API key.
