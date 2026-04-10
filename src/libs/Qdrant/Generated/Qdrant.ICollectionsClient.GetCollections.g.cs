#nullable enable

namespace Qdrant
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// List collections<br/>
        /// Get list name of all existing collections
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.GetCollectionsResponse> GetCollectionsAsync(
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}