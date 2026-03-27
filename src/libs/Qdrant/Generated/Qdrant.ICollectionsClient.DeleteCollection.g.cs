#nullable enable

namespace Qdrant
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Delete collection<br/>
        /// Drop collection and all associated data
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.DeleteCollectionResponse> DeleteCollectionAsync(
            string collectionName,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}