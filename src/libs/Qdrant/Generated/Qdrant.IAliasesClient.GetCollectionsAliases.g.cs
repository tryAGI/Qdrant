#nullable enable

namespace Qdrant
{
    public partial interface IAliasesClient
    {
        /// <summary>
        /// List collections aliases<br/>
        /// Get list of all existing collections aliases
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.GetCollectionsAliasesResponse> GetCollectionsAliasesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}