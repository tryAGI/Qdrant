#nullable enable

namespace Qdrant
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Delete shard snapshot<br/>
        /// Delete snapshot of a shard for a collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <param name="snapshotName"></param>
        /// <param name="wait"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.DeleteShardSnapshotResponse> DeleteShardSnapshotAsync(
            string collectionName,
            int shardId,
            string snapshotName,
            bool? wait = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}