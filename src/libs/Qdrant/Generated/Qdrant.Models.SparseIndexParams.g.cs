
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Configuration for sparse inverted index.
    /// </summary>
    public sealed partial class SparseIndexParams
    {
        /// <summary>
        /// We prefer a full scan search upto (excluding) this number of vectors.<br/>
        /// Note: this is number of vectors, not KiloBytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_scan_threshold")]
        public int? FullScanThreshold { get; set; }

        /// <summary>
        /// Deprecated: use `memory` instead. Store index on disk. If set to false, the index will be stored in RAM. Default: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_disk")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? OnDisk { get; set; }

        /// <summary>
        /// Memory placement of the index. Overrides the deprecated `on_disk` flag if both are set. Default: `pinned` (`cold` if `on_disk` is set to true).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public global::Qdrant.Memory? Memory { get; set; }

        /// <summary>
        /// Defines which datatype should be used for the index. Choosing different datatypes allows to optimize memory usage and performance vs accuracy.<br/>
        /// - For `float32` datatype - vectors are stored as single-precision floating point numbers, 4 bytes. - For `float16` datatype - vectors are stored as half-precision floating point numbers, 2 bytes. - For `uint8` datatype - vectors are quantized to unsigned 8-bit integers, 1 byte. Quantization to fit byte range `[0, 255]` happens during indexing automatically, so the actual vector data does not need to conform to this range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datatype")]
        public global::Qdrant.Datatype? Datatype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseIndexParams" /> class.
        /// </summary>
        /// <param name="fullScanThreshold">
        /// We prefer a full scan search upto (excluding) this number of vectors.<br/>
        /// Note: this is number of vectors, not KiloBytes.
        /// </param>
        /// <param name="memory">
        /// Memory placement of the index. Overrides the deprecated `on_disk` flag if both are set. Default: `pinned` (`cold` if `on_disk` is set to true).
        /// </param>
        /// <param name="datatype">
        /// Defines which datatype should be used for the index. Choosing different datatypes allows to optimize memory usage and performance vs accuracy.<br/>
        /// - For `float32` datatype - vectors are stored as single-precision floating point numbers, 4 bytes. - For `float16` datatype - vectors are stored as half-precision floating point numbers, 2 bytes. - For `uint8` datatype - vectors are quantized to unsigned 8-bit integers, 1 byte. Quantization to fit byte range `[0, 255]` happens during indexing automatically, so the actual vector data does not need to conform to this range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseIndexParams(
            int? fullScanThreshold,
            global::Qdrant.Memory? memory,
            global::Qdrant.Datatype? datatype)
        {
            this.FullScanThreshold = fullScanThreshold;
            this.Memory = memory;
            this.Datatype = datatype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseIndexParams" /> class.
        /// </summary>
        public SparseIndexParams()
        {
        }

    }
}