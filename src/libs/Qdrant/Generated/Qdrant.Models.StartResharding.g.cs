
#nullable enable

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StartResharding
    {
        /// <summary>
        /// Resharding direction, scale up or down in number of shards<br/>
        /// - `up` - Scale up, add a new shard<br/>
        /// - `down` - Scale down, remove a shard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ReshardingDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.ReshardingDirection Direction { get; set; }

        /// <summary>
        /// Peer to create the new shard on, or to migrate points away from when scaling down. If not specified, the least loaded peer is picked when scaling up, a peer holding the removed shard when scaling down.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peer_id")]
        public int? PeerId { get; set; }

        /// <summary>
        /// Custom shard key to reshard, must already exist. If not specified, shards without a shard key are resharded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::Qdrant.ShardKey? ShardKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartResharding" /> class.
        /// </summary>
        /// <param name="direction">
        /// Resharding direction, scale up or down in number of shards<br/>
        /// - `up` - Scale up, add a new shard<br/>
        /// - `down` - Scale down, remove a shard
        /// </param>
        /// <param name="peerId">
        /// Peer to create the new shard on, or to migrate points away from when scaling down. If not specified, the least loaded peer is picked when scaling up, a peer holding the removed shard when scaling down.
        /// </param>
        /// <param name="shardKey">
        /// Custom shard key to reshard, must already exist. If not specified, shards without a shard key are resharded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartResharding(
            global::Qdrant.ReshardingDirection direction,
            int? peerId,
            global::Qdrant.ShardKey? shardKey)
        {
            this.Direction = direction;
            this.PeerId = peerId;
            this.ShardKey = shardKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartResharding" /> class.
        /// </summary>
        public StartResharding()
        {
        }

    }
}