
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PointStruct
    {
        /// <summary>
        /// Type, used for specifying point ID in user interface
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ExtendedPointIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.ExtendedPointId Id { get; set; }

        /// <summary>
        /// Full vector data per point separator with single and multiple vector modes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.VectorStructJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.VectorStruct Vector { get; set; }

        /// <summary>
        /// Payload values (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public global::Qdrant.Payload? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointStruct" /> class.
        /// </summary>
        /// <param name="id">
        /// Type, used for specifying point ID in user interface
        /// </param>
        /// <param name="vector">
        /// Full vector data per point separator with single and multiple vector modes
        /// </param>
        /// <param name="payload">
        /// Payload values (optional)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PointStruct(
            global::Qdrant.ExtendedPointId id,
            global::Qdrant.VectorStruct vector,
            global::Qdrant.Payload? payload)
        {
            this.Id = id;
            this.Vector = vector;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointStruct" /> class.
        /// </summary>
        public PointStruct()
        {
        }
    }
}