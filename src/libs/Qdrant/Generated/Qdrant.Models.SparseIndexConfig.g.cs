
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Configuration for sparse inverted index.
    /// </summary>
    public sealed partial class SparseIndexConfig
    {
        /// <summary>
        /// We prefer a full scan search upto (excluding) this number of vectors.<br/>
        /// Note: this is number of vectors, not KiloBytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_scan_threshold")]
        public int? FullScanThreshold { get; set; }

        /// <summary>
        /// Sparse index types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.SparseIndexTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.SparseIndexType IndexType { get; set; }

        /// <summary>
        /// Datatype used to store weights in the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datatype")]
        public global::Qdrant.VectorStorageDatatype? Datatype { get; set; }

        /// <summary>
        /// Requested memory placement of the index.<br/>
        /// The structural decision is carried by `index_type`; this field additionally distinguishes `cold` from `cached` for the mmap index variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public global::Qdrant.Memory? Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseIndexConfig" /> class.
        /// </summary>
        /// <param name="indexType">
        /// Sparse index types
        /// </param>
        /// <param name="fullScanThreshold">
        /// We prefer a full scan search upto (excluding) this number of vectors.<br/>
        /// Note: this is number of vectors, not KiloBytes.
        /// </param>
        /// <param name="datatype">
        /// Datatype used to store weights in the index.
        /// </param>
        /// <param name="memory">
        /// Requested memory placement of the index.<br/>
        /// The structural decision is carried by `index_type`; this field additionally distinguishes `cold` from `cached` for the mmap index variant.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseIndexConfig(
            global::Qdrant.SparseIndexType indexType,
            int? fullScanThreshold,
            global::Qdrant.VectorStorageDatatype? datatype,
            global::Qdrant.Memory? memory)
        {
            this.FullScanThreshold = fullScanThreshold;
            this.IndexType = indexType;
            this.Datatype = datatype;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseIndexConfig" /> class.
        /// </summary>
        public SparseIndexConfig()
        {
        }

    }
}