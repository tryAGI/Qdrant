#nullable enable

namespace Qdrant
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Create shard snapshot<br/>
        /// Create new snapshot of a shard for a collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <param name="wait"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.CreateShardSnapshotResponse> CreateShardSnapshotAsync(
            string collectionName,
            int shardId,
            bool? wait = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}