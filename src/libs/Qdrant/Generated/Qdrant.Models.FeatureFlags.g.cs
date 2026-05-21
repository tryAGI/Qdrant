
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeatureFlags
    {
        /// <summary>
        /// Magic feature flag that enables all features.<br/>
        /// Note that this will only be applied to all flags when passed into [`init_feature_flags`].<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all")]
        public bool? All { get; set; }

        /// <summary>
        /// Use incremental HNSW building.<br/>
        /// Enabled by default in Qdrant 1.14.1.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incremental_hnsw_building")]
        public bool? IncrementalHnswBuilding { get; set; }

        /// <summary>
        /// Use appendable quantization in appendable plain segments.<br/>
        /// Enabled by default in Qdrant 1.16.0.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appendable_quantization")]
        public bool? AppendableQuantization { get; set; }

        /// <summary>
        /// Use single-file mmap in-ram vector storage (InRamMmap)<br/>
        /// Enabled by default in Qdrant 1.17.1+<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file_mmap_vector_storage")]
        public bool? SingleFileMmapVectorStorage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlags" /> class.
        /// </summary>
        /// <param name="all">
        /// Magic feature flag that enables all features.<br/>
        /// Note that this will only be applied to all flags when passed into [`init_feature_flags`].<br/>
        /// Default Value: false
        /// </param>
        /// <param name="incrementalHnswBuilding">
        /// Use incremental HNSW building.<br/>
        /// Enabled by default in Qdrant 1.14.1.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="appendableQuantization">
        /// Use appendable quantization in appendable plain segments.<br/>
        /// Enabled by default in Qdrant 1.16.0.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="singleFileMmapVectorStorage">
        /// Use single-file mmap in-ram vector storage (InRamMmap)<br/>
        /// Enabled by default in Qdrant 1.17.1+<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeatureFlags(
            bool? all,
            bool? incrementalHnswBuilding,
            bool? appendableQuantization,
            bool? singleFileMmapVectorStorage)
        {
            this.All = all;
            this.IncrementalHnswBuilding = incrementalHnswBuilding;
            this.AppendableQuantization = appendableQuantization;
            this.SingleFileMmapVectorStorage = singleFileMmapVectorStorage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlags" /> class.
        /// </summary>
        public FeatureFlags()
        {
        }

    }
}