#nullable enable

namespace Qdrant
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Remove peer from the cluster<br/>
        /// Tries to remove peer from the cluster. Will return an error if peer has shards on it.
        /// </summary>
        /// <param name="peerId"></param>
        /// <param name="timeout"></param>
        /// <param name="force">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.RemovePeerResponse> RemovePeerAsync(
            int peerId,
            int? timeout = default,
            bool? force = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}