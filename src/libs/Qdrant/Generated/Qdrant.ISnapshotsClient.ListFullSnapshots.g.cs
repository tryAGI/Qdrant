#nullable enable

namespace Qdrant
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// List of storage snapshots<br/>
        /// Get list of snapshots of the whole storage
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.ListFullSnapshotsResponse> ListFullSnapshotsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}