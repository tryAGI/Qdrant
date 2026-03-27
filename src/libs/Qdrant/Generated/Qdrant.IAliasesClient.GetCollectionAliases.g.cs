#nullable enable

namespace Qdrant
{
    public partial interface IAliasesClient
    {
        /// <summary>
        /// List aliases for collection<br/>
        /// Get list of all aliases for a collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.GetCollectionAliasesResponse> GetCollectionAliasesAsync(
            string collectionName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}