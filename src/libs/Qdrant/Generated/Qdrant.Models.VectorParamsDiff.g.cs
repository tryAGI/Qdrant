
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VectorParamsDiff
    {
        /// <summary>
        /// Update params for HNSW index. If empty object - it will be unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hnsw_config")]
        public global::Qdrant.HnswConfigDiff? HnswConfig { get; set; }

        /// <summary>
        /// Update params for quantization. If none - it is left unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization_config")]
        public global::Qdrant.QuantizationConfigDiff? QuantizationConfig { get; set; }

        /// <summary>
        /// Deprecated: use `memory` instead. If true, vectors are served from disk, improving RAM usage at the cost of latency
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_disk")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? OnDisk { get; set; }

        /// <summary>
        /// Memory placement of the original vector storage. Overrides the deprecated `on_disk` flag if both are set. `pinned` is not supported for dense vector storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public global::Qdrant.Memory? Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorParamsDiff" /> class.
        /// </summary>
        /// <param name="hnswConfig">
        /// Update params for HNSW index. If empty object - it will be unset.
        /// </param>
        /// <param name="quantizationConfig">
        /// Update params for quantization. If none - it is left unchanged.
        /// </param>
        /// <param name="memory">
        /// Memory placement of the original vector storage. Overrides the deprecated `on_disk` flag if both are set. `pinned` is not supported for dense vector storage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorParamsDiff(
            global::Qdrant.HnswConfigDiff? hnswConfig,
            global::Qdrant.QuantizationConfigDiff? quantizationConfig,
            global::Qdrant.Memory? memory)
        {
            this.HnswConfig = hnswConfig;
            this.QuantizationConfig = quantizationConfig;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorParamsDiff" /> class.
        /// </summary>
        public VectorParamsDiff()
        {
        }

    }
}