
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionConfigTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.CollectionParams Params { get; set; }

        /// <summary>
        /// Config of HNSW index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hnsw_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.HnswConfig HnswConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizer_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.OptimizersConfig OptimizerConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wal_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.WalConfig WalConfig { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization_config")]
        public global::Qdrant.QuantizationConfig? QuantizationConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_mode_config")]
        public global::Qdrant.StrictModeConfigOutput? StrictModeConfig { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public global::System.Guid? Uuid { get; set; }

        /// <summary>
        /// Arbitrary JSON metadata for the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Qdrant.Payload? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionConfigTelemetry" /> class.
        /// </summary>
        /// <param name="params"></param>
        /// <param name="hnswConfig">
        /// Config of HNSW index
        /// </param>
        /// <param name="optimizerConfig"></param>
        /// <param name="walConfig"></param>
        /// <param name="quantizationConfig">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="strictModeConfig"></param>
        /// <param name="uuid">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata for the collection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionConfigTelemetry(
            global::Qdrant.CollectionParams @params,
            global::Qdrant.HnswConfig hnswConfig,
            global::Qdrant.OptimizersConfig optimizerConfig,
            global::Qdrant.WalConfig walConfig,
            global::Qdrant.QuantizationConfig? quantizationConfig,
            global::Qdrant.StrictModeConfigOutput? strictModeConfig,
            global::System.Guid? uuid,
            global::Qdrant.Payload? metadata)
        {
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
            this.HnswConfig = hnswConfig ?? throw new global::System.ArgumentNullException(nameof(hnswConfig));
            this.OptimizerConfig = optimizerConfig ?? throw new global::System.ArgumentNullException(nameof(optimizerConfig));
            this.WalConfig = walConfig ?? throw new global::System.ArgumentNullException(nameof(walConfig));
            this.QuantizationConfig = quantizationConfig;
            this.StrictModeConfig = strictModeConfig;
            this.Uuid = uuid;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionConfigTelemetry" /> class.
        /// </summary>
        public CollectionConfigTelemetry()
        {
        }
    }
}