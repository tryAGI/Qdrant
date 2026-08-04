
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BinaryQuantizationConfig
    {
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        public global::Qdrant.BinaryQuantizationEncoding? Encoding { get; set; }

        /// <summary>
        /// Asymmetric quantization configuration allows a query to have different quantization than stored vectors. It can increase the accuracy of search at the cost of performance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_encoding")]
        public global::Qdrant.BinaryQuantizationQueryEncoding? QueryEncoding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryQuantizationConfig" /> class.
        /// </summary>
        /// <param name="memory">
        /// Memory placement of quantized vectors. Overrides the deprecated `always_ram` flag if both are set. Default: follow the memory placement of the original vector storage.
        /// </param>
        /// <param name="encoding"></param>
        /// <param name="queryEncoding">
        /// Asymmetric quantization configuration allows a query to have different quantization than stored vectors. It can increase the accuracy of search at the cost of performance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BinaryQuantizationConfig(
            global::Qdrant.Memory? memory,
            global::Qdrant.BinaryQuantizationEncoding? encoding,
            global::Qdrant.BinaryQuantizationQueryEncoding? queryEncoding)
        {
            this.Memory = memory;
            this.Encoding = encoding;
            this.QueryEncoding = queryEncoding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryQuantizationConfig" /> class.
        /// </summary>
        public BinaryQuantizationConfig()
        {
        }

    }
}