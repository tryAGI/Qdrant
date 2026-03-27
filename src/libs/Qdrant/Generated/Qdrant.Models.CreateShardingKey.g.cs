
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateShardingKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ShardKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.ShardKey ShardKey { get; set; }

        /// <summary>
        /// How many shards to create for this key If not specified, will use the default value from config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shards_number")]
        public int? ShardsNumber { get; set; }

        /// <summary>
        /// How many replicas to create for each shard If not specified, will use the default value from config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replication_factor")]
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// Placement of shards for this key List of peer ids, that can be used to place shards for this key If not specified, will be randomly placed among all peers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement")]
        public global::System.Collections.Generic.IList<int>? Placement { get; set; }

        /// <summary>
        /// Initial state of the shards for this key If not specified, will be `Initializing` first and then `Active` Warning: do not change this unless you know what you are doing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_state")]
        public global::Qdrant.ReplicaState? InitialState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShardingKey" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateShardingKey(
            global::Qdrant.ShardKey shardKey,
            int? shardsNumber,
            int? replicationFactor,
            global::System.Collections.Generic.IList<int>? placement,
            global::Qdrant.ReplicaState? initialState)
        {
            this.ShardKey = shardKey;
            this.ShardsNumber = shardsNumber;
            this.ReplicationFactor = replicationFactor;
            this.Placement = placement;
            this.InitialState = initialState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShardingKey" /> class.
        /// </summary>
        public CreateShardingKey()
        {
        }
    }
}