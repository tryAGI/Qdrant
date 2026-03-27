#nullable enable

namespace Qdrant
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Get cluster status info<br/>
        /// Get information about the current state and composition of the cluster
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.ClusterStatusResponse> ClusterStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}