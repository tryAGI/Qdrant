#nullable enable

namespace Qdrant
{
    public partial interface IDistributedClient
    {
        /// <summary>
        /// Create shard key
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.CreateShardKeyResponse> CreateShardKeyAsync(
            string collectionName,

            global::Qdrant.CreateShardingKey request,
            int? timeout = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create shard key
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="timeout"></param>
        /// <param name="shardKey"></param>
        /// <param name="shardsNumber">
        /// How many shards to create for this key If not specified, will use the default value from config
        /// </param>
        /// <param name="replicationFactor">
        /// How many replicas to create for each shard If not specified, will use the default value from config
        /// </param>
        /// <param name="placement">
        /// Placement of shards for this key List of peer ids, that can be used to place shards for this key If not specified, will be randomly placed among all peers
        /// </param>
        /// <param name="initialState">
        /// Initial state of the shards for this key If not specified, will be `Initializing` first and then `Active` Warning: do not change this unless you know what you are doing
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.CreateShardKeyResponse> CreateShardKeyAsync(
            string collectionName,
            global::Qdrant.ShardKey shardKey,
            int? timeout = default,
            int? shardsNumber = default,
            int? replicationFactor = default,
            global::System.Collections.Generic.IList<int>? placement = default,
            global::Qdrant.ReplicaState? initialState = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}