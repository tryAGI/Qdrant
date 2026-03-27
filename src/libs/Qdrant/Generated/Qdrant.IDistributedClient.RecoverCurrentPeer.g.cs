#nullable enable

namespace Qdrant
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Tries to recover current peer Raft state.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.RecoverCurrentPeerResponse> RecoverCurrentPeerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}