
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplicatePoints
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Qdrant.Filter? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_shard_key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ShardKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.ShardKey FromShardKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_shard_key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ShardKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.ShardKey ToShardKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicatePoints" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="fromShardKey"></param>
        /// <param name="toShardKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicatePoints(
            global::Qdrant.ShardKey fromShardKey,
            global::Qdrant.ShardKey toShardKey,
            global::Qdrant.Filter? filter)
        {
            this.FromShardKey = fromShardKey;
            this.ToShardKey = toShardKey;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicatePoints" /> class.
        /// </summary>
        public ReplicatePoints()
        {
        }
    }
}