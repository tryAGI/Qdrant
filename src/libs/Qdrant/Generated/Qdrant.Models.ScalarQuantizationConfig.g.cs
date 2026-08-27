
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScalarQuantizationConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ScalarTypeJsonConverter))]
        public global::Qdrant.ScalarType Type { get; set; }

        /// <summary>
        /// Quantile for quantization. Expected value range in [0.5, 1.0]. If not set - use the whole range of values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantile")]
        public float? Quantile { get; set; }

        /// <summary>
        /// Deprecated: use `memory` instead. If true - quantized vectors always will be stored in RAM, ignoring the config of main storage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("always_ram")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? AlwaysRam { get; set; }

        /// <summary>
        /// Memory placement of quantized vectors. Overrides the deprecated `always_ram` flag if both are set. Default: follow the memory placement of the original vector storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public global::Qdrant.Memory? Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarQuantizationConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="quantile">
        /// Quantile for quantization. Expected value range in [0.5, 1.0]. If not set - use the whole range of values
        /// </param>
        /// <param name="memory">
        /// Memory placement of quantized vectors. Overrides the deprecated `always_ram` flag if both are set. Default: follow the memory placement of the original vector storage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScalarQuantizationConfig(
            global::Qdrant.ScalarType type,
            float? quantile,
            global::Qdrant.Memory? memory)
        {
            this.Type = type;
            this.Quantile = quantile;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarQuantizationConfig" /> class.
        /// </summary>
        public ScalarQuantizationConfig()
        {
        }

    }
}