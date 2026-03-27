
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentConfig
    {
        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_data")]
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataConfig>? VectorData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_vector_data")]
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorDataConfig>? SparseVectorData { get; set; }

        /// <summary>
        /// Type of payload storage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload_storage_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.PayloadStorageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.PayloadStorageType PayloadStorageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentConfig" /> class.
        /// </summary>
        /// <param name="vectorData">
        /// Default Value: {}
        /// </param>
        /// <param name="sparseVectorData"></param>
        /// <param name="payloadStorageType">
        /// Type of payload storage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentConfig(
            global::Qdrant.PayloadStorageType payloadStorageType,
            global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorDataConfig>? vectorData,
            global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorDataConfig>? sparseVectorData)
        {
            this.PayloadStorageType = payloadStorageType;
            this.VectorData = vectorData;
            this.SparseVectorData = sparseVectorData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentConfig" /> class.
        /// </summary>
        public SegmentConfig()
        {
        }
    }
}