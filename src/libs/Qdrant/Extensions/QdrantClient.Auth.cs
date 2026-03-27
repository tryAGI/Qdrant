#nullable enable

namespace Qdrant;

public partial class QdrantClient
{
    // Qdrant uses "api-key" header instead of "Authorization: Bearer".
    // The generated code sends "Authorization: Bearer <key>" but Qdrant
    // expects the API key in the "api-key" header.
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Performance",
        "CA1822:Mark members as static",
        Justification = "The generated partial method declaration is instance-based.")]
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } apiKey })
        {
            request.Headers.Authorization = null;
            request.Headers.TryAddWithoutValidation("api-key", apiKey);
        }
    }
}
