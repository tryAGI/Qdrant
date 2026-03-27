
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoteShardInfo
    {
        /// <summary>
        /// Remote shard id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ShardId { get; set; }

        /// <summary>
        /// User-defined sharding key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::Qdrant.ShardKey? ShardKey { get; set; }

        /// <summary>
        /// Remote peer id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeerId { get; set; }

        /// <summary>
        /// State of the single shard within a replica set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ReplicaStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.ReplicaState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteShardInfo" /> class.
        /// </summary>
        /// <param name="shardId">
        /// Remote shard id
        /// </param>
        /// <param name="shardKey">
        /// User-defined sharding key
        /// </param>
        /// <param name="peerId">
        /// Remote peer id
        /// </param>
        /// <param name="state">
        /// State of the single shard within a replica set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoteShardInfo(
            int shardId,
            int peerId,
            global::Qdrant.ReplicaState state,
            global::Qdrant.ShardKey? shardKey)
        {
            this.ShardId = shardId;
            this.PeerId = peerId;
            this.State = state;
            this.ShardKey = shardKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteShardInfo" /> class.
        /// </summary>
        public RemoteShardInfo()
        {
        }
    }
}