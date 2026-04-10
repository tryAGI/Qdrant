#nullable enable

namespace Qdrant
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Collect Prometheus metrics data<br/>
        /// Collect metrics data including app info, collections info, cluster info and statistics
        /// </summary>
        /// <param name="anonymize"></param>
        /// <param name="perCollection"></param>
        /// <param name="timeout">
        /// Default Value: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MetricsAsync(
            bool? anonymize = default,
            bool? perCollection = default,
            int? timeout = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}