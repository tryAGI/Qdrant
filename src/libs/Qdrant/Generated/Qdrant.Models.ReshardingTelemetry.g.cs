
#nullable enable

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReshardingTelemetry
    {
        /// <summary>
        /// Resharding stages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ReshardingStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.ReshardingStage Stage { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ShardId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::Qdrant.ShardKey? ShardKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReshardingTelemetry" /> class.
        /// </summary>
        /// <param name="stage">
        /// Resharding stages
        /// </param>
        /// <param name="direction">
        /// Resharding direction, scale up or down in number of shards<br/>
        /// - `up` - Scale up, add a new shard<br/>
        /// - `down` - Scale down, remove a shard
        /// </param>
        /// <param name="shardId"></param>
        /// <param name="peerId"></param>
        /// <param name="uuid"></param>
        /// <param name="shardKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReshardingTelemetry(
            global::Qdrant.ReshardingStage stage,
            global::Qdrant.ReshardingDirection direction,
            int shardId,
            int peerId,
            global::System.Guid uuid,
            global::Qdrant.ShardKey? shardKey)
        {
            this.Stage = stage;
            this.Direction = direction;
            this.ShardId = shardId;
            this.PeerId = peerId;
            this.ShardKey = shardKey;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReshardingTelemetry" /> class.
        /// </summary>
        public ReshardingTelemetry()
        {
        }

    }
}