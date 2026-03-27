
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PointRequest
    {
        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::Qdrant.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Look for points with ids
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Qdrant.ExtendedPointId> Ids { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointRequest" /> class.
        /// </summary>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="ids">
        /// Look for points with ids
        /// </param>
        /// <param name="withPayload">
        /// Select which payload to return with the response. Default is true.
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vector to include
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PointRequest(
            global::System.Collections.Generic.IList<global::Qdrant.ExtendedPointId> ids,
            global::Qdrant.ShardKeySelector? shardKey,
            global::Qdrant.WithPayloadInterface? withPayload,
            global::Qdrant.WithVector? withVector)
        {
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
            this.ShardKey = shardKey;
            this.WithPayload = withPayload;
            this.WithVector = withVector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointRequest" /> class.
        /// </summary>
        public PointRequest()
        {
        }
    }
}