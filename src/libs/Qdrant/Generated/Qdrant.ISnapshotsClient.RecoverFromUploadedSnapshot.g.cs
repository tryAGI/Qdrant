#nullable enable

namespace Qdrant
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Recover from an uploaded snapshot<br/>
        /// Recover local collection data from an uploaded snapshot. This will overwrite any data, stored on this node, for the collection. If collection does not exist - it will be created.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="wait"></param>
        /// <param name="priority">
        /// Defines source of truth for snapshot recovery:<br/>
        /// `NoSync` means - restore snapshot without *any* additional synchronization. `Snapshot` means - prefer snapshot data over the current state. `Replica` means - prefer existing data over the snapshot.
        /// </param>
        /// <param name="checksum"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.RecoverFromUploadedSnapshotResponse> RecoverFromUploadedSnapshotAsync(
            string collectionName,

            global::Qdrant.RecoverFromUploadedSnapshotRequest request,
            bool? wait = default,
            global::Qdrant.SnapshotPriority? priority = default,
            string? checksum = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recover from an uploaded snapshot<br/>
        /// Recover local collection data from an uploaded snapshot. This will overwrite any data, stored on this node, for the collection. If collection does not exist - it will be created.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="wait"></param>
        /// <param name="priority">
        /// Defines source of truth for snapshot recovery:<br/>
        /// `NoSync` means - restore snapshot without *any* additional synchronization. `Snapshot` means - prefer snapshot data over the current state. `Replica` means - prefer existing data over the snapshot.
        /// </param>
        /// <param name="checksum"></param>
        /// <param name="snapshot"></param>
        /// <param name="snapshotname"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.RecoverFromUploadedSnapshotResponse> RecoverFromUploadedSnapshotAsync(
            string collectionName,
            bool? wait = default,
            global::Qdrant.SnapshotPriority? priority = default,
            string? checksum = default,
            byte[]? snapshot = default,
            string? snapshotname = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}