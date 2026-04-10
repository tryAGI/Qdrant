#nullable enable

namespace Qdrant
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Get cluster status info<br/>
        /// Get information about the current state and composition of the cluster
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.ClusterStatusResponse> ClusterStatusAsync(
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}