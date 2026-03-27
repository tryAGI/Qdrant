#nullable enable

namespace Qdrant
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Download shard snapshot<br/>
        /// Stream the current state of a shard as a snapshot file
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamShardSnapshotAsync(
            string collectionName,
            int shardId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}