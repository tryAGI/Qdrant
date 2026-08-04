#nullable enable

namespace Qdrant
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Kubernetes healthz endpoint<br/>
        /// Liveness-style health check. Returns 200 as soon as the HTTP API is serving requests. It does not inspect collections, shards or consensus state, and is identical to `/livez`. Use it only to detect whether the process is up and responsive.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthzAsync(
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Kubernetes healthz endpoint<br/>
        /// Liveness-style health check. Returns 200 as soon as the HTTP API is serving requests. It does not inspect collections, shards or consensus state, and is identical to `/livez`. Use it only to detect whether the process is up and responsive.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.AutoSDKHttpResponse<string>> HealthzAsResponseAsync(
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}