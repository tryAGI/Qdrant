#nullable enable

namespace Qdrant
{
    public partial interface IAliasesClient
    {
        /// <summary>
        /// Update aliases of the collections
        /// </summary>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.UpdateAliasesResponse> UpdateAliasesAsync(

            global::Qdrant.ChangeAliasesOperation request,
            int? timeout = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update aliases of the collections
        /// </summary>
        /// <param name="timeout"></param>
        /// <param name="actions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.UpdateAliasesResponse> UpdateAliasesAsync(
            global::System.Collections.Generic.IList<global::Qdrant.AliasOperations> actions,
            int? timeout = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}