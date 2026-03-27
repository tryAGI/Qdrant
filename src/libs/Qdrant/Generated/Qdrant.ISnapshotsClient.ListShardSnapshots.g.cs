#nullable enable

namespace Qdrant
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// List shards snapshots for a collection<br/>
        /// Get list of snapshots for a shard of a collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.ListShardSnapshotsResponse> ListShardSnapshotsAsync(
            string collectionName,
            int shardId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}