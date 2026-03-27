
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Scroll request - paginate over all points which matches given condition
    /// </summary>
    public sealed partial class ScrollRequest
    {
        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::Qdrant.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Start ID to read points from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public global::Qdrant.ExtendedPointId? Offset { get; set; }

        /// <summary>
        /// Page size. Default: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Look only for points which satisfies this conditions. If not provided - all points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Qdrant.Filter? Filter { get; set; }

        /// <summary>
        /// Select which payload to return with the response. Default is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_payload")]
        public global::Qdrant.WithPayloadInterface? WithPayload { get; set; }

        /// <summary>
        /// Options for specifying which vector to include
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_vector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.WithVectorJsonConverter))]
        public global::Qdrant.WithVector? WithVector { get; set; }

        /// <summary>
        /// Order the records by a payload field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public global::Qdrant.OrderByInterface? OrderBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollRequest" /> class.
        /// </summary>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="offset">
        /// Start ID to read points from.
        /// </param>
        /// <param name="limit">
        /// Page size. Default: 10
        /// </param>
        /// <param name="filter">
        /// Look only for points which satisfies this conditions. If not provided - all points.
        /// </param>
        /// <param name="withPayload">
        /// Select which payload to return with the response. Default is true.
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vector to include
        /// </param>
        /// <param name="orderBy">
        /// Order the records by a payload field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrollRequest(
            global::Qdrant.ShardKeySelector? shardKey,
            global::Qdrant.ExtendedPointId? offset,
            int? limit,
            global::Qdrant.Filter? filter,
            global::Qdrant.WithPayloadInterface? withPayload,
            global::Qdrant.WithVector? withVector,
            global::Qdrant.OrderByInterface? orderBy)
        {
            this.ShardKey = shardKey;
            this.Offset = offset;
            this.Limit = limit;
            this.Filter = filter;
            this.WithPayload = withPayload;
            this.WithVector = withVector;
            this.OrderBy = orderBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollRequest" /> class.
        /// </summary>
        public ScrollRequest()
        {
        }
    }
}