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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.CreateShardSnapshotResponse> CreateShardSnapshotAsync(
            string collectionName,
            int shardId,
            bool? wait = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}