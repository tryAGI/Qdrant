#nullable enable

namespace Qdrant
{
    public partial interface IQuotasClient
    {
        /// <summary>
        /// Get global quotas<br/>
        /// Get the cluster-wide resource quota configuration, together with the current utilization it is measured against.<br/>
        /// The configuration is the same on every peer, but the reported utilization is for the node serving this request only -<br/>
        /// memory and disk are node-local, so query each peer to see where the whole cluster stands.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.GetQuotasResponse> GetQuotasAsync(
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get global quotas<br/>
        /// Get the cluster-wide resource quota configuration, together with the current utilization it is measured against.<br/>
        /// The configuration is the same on every peer, but the reported utilization is for the node serving this request only -<br/>
        /// memory and disk are node-local, so query each peer to see where the whole cluster stands.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.AutoSDKHttpResponse<global::Qdrant.GetQuotasResponse>> GetQuotasAsResponseAsync(
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}