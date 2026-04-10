#nullable enable

namespace Qdrant
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// List of storage snapshots<br/>
        /// Get list of snapshots of the whole storage
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.ListFullSnapshotsResponse> ListFullSnapshotsAsync(
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}