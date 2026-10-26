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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamShardSnapshotAsync(
            string collectionName,
            int shardId,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download shard snapshot<br/>
        /// Stream the current state of a shard as a snapshot file
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamShardSnapshotAsStreamAsync(
            string collectionName,
            int shardId,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download shard snapshot<br/>
        /// Stream the current state of a shard as a snapshot file
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.AutoSDKHttpResponse<global::System.IO.Stream>> StreamShardSnapshotAsStreamAsResponseAsync(
            string collectionName,
            int shardId,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download shard snapshot<br/>
        /// Stream the current state of a shard as a snapshot file
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.AutoSDKHttpResponse<byte[]>> StreamShardSnapshotAsResponseAsync(
            string collectionName,
            int shardId,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}