
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductQuantizationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.CompressionRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.CompressionRatio Compression { get; set; }

        /// <summary>
        /// Deprecated: use `memory` instead.
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
        /// Initializes a new instance of the <see cref="ProductQuantizationConfig" /> class.
        /// </summary>
        /// <param name="compression"></param>
        /// <param name="memory">
        /// Memory placement of quantized vectors. Overrides the deprecated `always_ram` flag if both are set. Default: follow the memory placement of the original vector storage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductQuantizationConfig(
            global::Qdrant.CompressionRatio compression,
            global::Qdrant.Memory? memory)
        {
            this.Compression = compression;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductQuantizationConfig" /> class.
        /// </summary>
        public ProductQuantizationConfig()
        {
        }

    }
}