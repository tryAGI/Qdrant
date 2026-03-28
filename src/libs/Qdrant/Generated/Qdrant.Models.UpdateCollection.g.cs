
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Operation for updating parameters of the existing collection
    /// </summary>
    public sealed partial class UpdateCollection
    {
        /// <summary>
        /// Map of vector data parameters to update for each named vector. To update parameters in a collection having a single unnamed vector, use an empty string as name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectors")]
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorParamsDiff>? Vectors { get; set; }

        /// <summary>
        /// Custom params for Optimizers.  If none - it is left unchanged. This operation is blocking, it will only proceed once all current optimizations are complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizers_config")]
        public global::Qdrant.OptimizersConfigDiff? OptimizersConfig { get; set; }

        /// <summary>
        /// Collection base params. If none - it is left unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::Qdrant.CollectionParamsDiff? Params { get; set; }

        /// <summary>
        /// HNSW parameters to update for the collection index. If none - it is left unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hnsw_config")]
        public global::Qdrant.HnswConfigDiff? HnswConfig { get; set; }

        /// <summary>
        /// Quantization parameters to update. If none - it is left unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization_config")]
        public global::Qdrant.QuantizationConfigDiff? QuantizationConfig { get; set; }

        /// <summary>
        /// Map of sparse vector data parameters to update for each sparse vector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_vectors")]
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorParams>? SparseVectors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_mode_config")]
        public global::Qdrant.StrictModeConfig? StrictModeConfig { get; set; }

        /// <summary>
        /// Metadata to update for the collection. If provided, this will merge with existing metadata. To remove metadata, set it to an empty object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Qdrant.Payload? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollection" /> class.
        /// </summary>
        /// <param name="vectors">
        /// Map of vector data parameters to update for each named vector. To update parameters in a collection having a single unnamed vector, use an empty string as name.
        /// </param>
        /// <param name="optimizersConfig">
        /// Custom params for Optimizers.  If none - it is left unchanged. This operation is blocking, it will only proceed once all current optimizations are complete
        /// </param>
        /// <param name="params">
        /// Collection base params. If none - it is left unchanged.
        /// </param>
        /// <param name="hnswConfig">
        /// HNSW parameters to update for the collection index. If none - it is left unchanged.
        /// </param>
        /// <param name="quantizationConfig">
        /// Quantization parameters to update. If none - it is left unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sparseVectors">
        /// Map of sparse vector data parameters to update for each sparse vector.
        /// </param>
        /// <param name="strictModeConfig"></param>
        /// <param name="metadata">
        /// Metadata to update for the collection. If provided, this will merge with existing metadata. To remove metadata, set it to an empty object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCollection(
            global::System.Collections.Generic.Dictionary<string, global::Qdrant.VectorParamsDiff>? vectors,
            global::Qdrant.OptimizersConfigDiff? optimizersConfig,
            global::Qdrant.CollectionParamsDiff? @params,
            global::Qdrant.HnswConfigDiff? hnswConfig,
            global::Qdrant.QuantizationConfigDiff? quantizationConfig,
            global::System.Collections.Generic.Dictionary<string, global::Qdrant.SparseVectorParams>? sparseVectors,
            global::Qdrant.StrictModeConfig? strictModeConfig,
            global::Qdrant.Payload? metadata)
        {
            this.Vectors = vectors;
            this.OptimizersConfig = optimizersConfig;
            this.Params = @params;
            this.HnswConfig = hnswConfig;
            this.QuantizationConfig = quantizationConfig;
            this.SparseVectors = sparseVectors;
            this.StrictModeConfig = strictModeConfig;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCollection" /> class.
        /// </summary>
        public UpdateCollection()
        {
        }
    }
}