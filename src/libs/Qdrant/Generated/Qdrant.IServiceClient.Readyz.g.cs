#nullable enable

namespace Qdrant
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Kubernetes readyz endpoint<br/>
        /// Kubernetes readiness probe. Checks the instance and waits out pending data operations to see when it can start accepting traffic. In a distributed deployment it returns 200 only once the node has caught up with the cluster consensus commit and its local shards are healthy; otherwise it returns 503. In a single-node deployment it always returns 200 once the API is up. Use it to decide when to route traffic to the instance.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReadyzAsync(
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Kubernetes readyz endpoint<br/>
        /// Kubernetes readiness probe. Checks the instance and waits out pending data operations to see when it can start accepting traffic. In a distributed deployment it returns 200 only once the node has caught up with the cluster consensus commit and its local shards are healthy; otherwise it returns 503. In a single-node deployment it always returns 200 once the API is up. Use it to decide when to route traffic to the instance.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.AutoSDKHttpResponse<string>> ReadyzAsResponseAsync(
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}