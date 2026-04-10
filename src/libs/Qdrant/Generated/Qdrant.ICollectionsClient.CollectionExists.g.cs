#nullable enable

namespace Qdrant
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Check the existence of a collection<br/>
        /// Returns "true" if the given collection name exists, and "false" otherwise
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.CollectionExistsResponse> CollectionExistsAsync(
            string collectionName,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}