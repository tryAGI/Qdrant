
#nullable enable

namespace Qdrant
{
    public sealed partial class QdrantClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Qdrant.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "api-key",
                Value = apiKey,
            });
        }
    }
}