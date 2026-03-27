#nullable enable

namespace Qdrant
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Collection cluster info<br/>
        /// Get cluster information for a collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.CollectionClusterInfoResponse> CollectionClusterInfoAsync(
            string collectionName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}