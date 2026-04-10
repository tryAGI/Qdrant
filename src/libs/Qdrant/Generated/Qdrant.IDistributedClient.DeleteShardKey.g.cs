#nullable enable

namespace Qdrant
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Delete shard key
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.DeleteShardKeyResponse> DeleteShardKeyAsync(
            string collectionName,

            global::Qdrant.DropShardingKey request,
            int? timeout = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete shard key
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="shardKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.DeleteShardKeyResponse> DeleteShardKeyAsync(
            string collectionName,
            global::Qdrant.ShardKey shardKey,
            int? timeout = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}