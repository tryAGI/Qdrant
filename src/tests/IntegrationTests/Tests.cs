namespace Qdrant.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static QdrantClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("QDRANT_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("QDRANT_API_KEY environment variable is not found.");

        var client = new QdrantClient(apiKey);
        
        return client;
    }
}
