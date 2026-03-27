#nullable enable

namespace Qdrant
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Collection info<br/>
        /// Get detailed information about specified existing collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.GetCollectionResponse> GetCollectionAsync(
            string collectionName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}