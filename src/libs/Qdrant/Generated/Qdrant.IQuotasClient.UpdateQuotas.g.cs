#nullable enable

namespace Qdrant
{
    public partial interface IQuotasClient
    {
        /// <summary>
        /// Set global quotas<br/>
        /// Replace the cluster-wide resource quota configuration. The new configuration is propagated to every peer through consensus and persisted, so it survives restarts
        /// </summary>
        /// <param name="wait">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.UpdateQuotasResponse> UpdateQuotasAsync(

            global::Qdrant.QuotaConfig request,
            bool? wait = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set global quotas<br/>
        /// Replace the cluster-wide resource quota configuration. The new configuration is propagated to every peer through consensus and persisted, so it survives restarts
        /// </summary>
        /// <param name="wait">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.AutoSDKHttpResponse<global::Qdrant.UpdateQuotasResponse>> UpdateQuotasAsResponseAsync(

            global::Qdrant.QuotaConfig request,
            bool? wait = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set global quotas<br/>
        /// Replace the cluster-wide resource quota configuration. The new configuration is propagated to every peer through consensus and persisted, so it survives restarts
        /// </summary>
        /// <param name="wait">
        /// Default Value: false
        /// </param>
        /// <param name="enabled">
        /// Whether the limits below are enforced.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxResidentMemoryPercent">
        /// Reject memory-consuming updates once process resident memory reaches this percentage of total system memory (or of the cgroup limit, if one applies).
        /// </param>
        /// <param name="maxDiskUsagePercent">
        /// Reject disk-consuming updates once the filesystem hosting the storage directory is filled to this percentage of its capacity.
        /// </param>
        /// <param name="releaseMarginPercent">
        /// How many percentage points below its limit a resource has to fall before this node starts accepting work again.<br/>
        /// Without a margin, a resource resting on its limit crosses it in both directions on the noise between two readings, putting the node in and out of service each time — and restarting a shard recovery with it. Raise it where usage is volatile; `0` disables the margin and releases as soon as usage is back under the limit.<br/>
        /// Unset leaves the built-in default in force, so a config written today does not pin a number that a later release may want to revise.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.UpdateQuotasResponse> UpdateQuotasAsync(
            bool? wait = default,
            bool? enabled = default,
            byte? maxResidentMemoryPercent = default,
            byte? maxDiskUsagePercent = default,
            byte? releaseMarginPercent = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}