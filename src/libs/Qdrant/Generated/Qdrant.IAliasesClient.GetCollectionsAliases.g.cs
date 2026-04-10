#nullable enable

namespace Qdrant
{
    public partial interface IAliasesClient
    {
        /// <summary>
        /// List collections aliases<br/>
        /// Get list of all existing collections aliases
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.GetCollectionsAliasesResponse> GetCollectionsAliasesAsync(
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}