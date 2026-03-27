#nullable enable

namespace Qdrant
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Collect telemetry data<br/>
        /// Collect telemetry data including app info, system info, collections info, cluster info, configs and statistics
        /// </summary>
        /// <param name="anonymize"></param>
        /// <param name="detailsLevel"></param>
        /// <param name="perCollection"></param>
        /// <param name="timeout">
        /// Default Value: 60
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.TelemetryResponse> TelemetryAsync(
            bool? anonymize = default,
            int? detailsLevel = default,
            bool? perCollection = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}