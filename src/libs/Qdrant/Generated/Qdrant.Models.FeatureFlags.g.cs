
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
        /// Enabled by default in Qdrant 1.18.3+<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file_mmap_vector_storage")]
        public bool? SingleFileMmapVectorStorage { get; set; }

        /// <summary>
        /// Allow the io_uring-based payload storage implementation. When disabled, io_uring payload storage is *never* used. When enabled, payload storage backend is decided based on `storage.performance.io_uring` option and payload storage type.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async_payload_storage")]
        public bool? AsyncPayloadStorage { get; set; }

        /// <summary>
        /// Write a segment manifest (`segments_manifest.json`, next to the `segments/` directory) listing the shard's segments and their state, so out-of-process readers can discover segments without scanning the filesystem.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_segment_manifest")]
        public bool? WriteSegmentManifest { get; set; }

        /// <summary>
        /// Build new segments in append-only mode: in-place point mutations become clone-and-tombstone appends instead. Intended for testing the append-only storage path.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("append_only_mutations")]
        public bool? AppendOnlyMutations { get; set; }

        /// <summary>
        /// Persist write-once bitmasks in the compact `StoredBitmask` format instead of raw dense bitslices. Only gates writing: both formats are always readable.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compact_bitmask")]
        public bool? CompactBitmask { get; set; }

        /// <summary>
        /// Serverless-compatible deployment mode. Automatically enables [`Self::write_segment_manifest`], [`Self::append_only_mutations`] and [`Self::compact_bitmask`].<br/>
        /// Note that this will only be applied when passed into [`init_feature_flags`].<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverless_compatible")]
        public bool? ServerlessCompatible { get; set; }

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
        /// Enabled by default in Qdrant 1.18.3+<br/>
        /// Default Value: true
        /// </param>
        /// <param name="asyncPayloadStorage">
        /// Allow the io_uring-based payload storage implementation. When disabled, io_uring payload storage is *never* used. When enabled, payload storage backend is decided based on `storage.performance.io_uring` option and payload storage type.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="writeSegmentManifest">
        /// Write a segment manifest (`segments_manifest.json`, next to the `segments/` directory) listing the shard's segments and their state, so out-of-process readers can discover segments without scanning the filesystem.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="appendOnlyMutations">
        /// Build new segments in append-only mode: in-place point mutations become clone-and-tombstone appends instead. Intended for testing the append-only storage path.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="compactBitmask">
        /// Persist write-once bitmasks in the compact `StoredBitmask` format instead of raw dense bitslices. Only gates writing: both formats are always readable.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="serverlessCompatible">
        /// Serverless-compatible deployment mode. Automatically enables [`Self::write_segment_manifest`], [`Self::append_only_mutations`] and [`Self::compact_bitmask`].<br/>
        /// Note that this will only be applied when passed into [`init_feature_flags`].<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeatureFlags(
            bool? all,
            bool? incrementalHnswBuilding,
            bool? appendableQuantization,
            bool? singleFileMmapVectorStorage,
            bool? asyncPayloadStorage,
            bool? writeSegmentManifest,
            bool? appendOnlyMutations,
            bool? compactBitmask,
            bool? serverlessCompatible)
        {
            this.All = all;
            this.IncrementalHnswBuilding = incrementalHnswBuilding;
            this.AppendableQuantization = appendableQuantization;
            this.SingleFileMmapVectorStorage = singleFileMmapVectorStorage;
            this.AsyncPayloadStorage = asyncPayloadStorage;
            this.WriteSegmentManifest = writeSegmentManifest;
            this.AppendOnlyMutations = appendOnlyMutations;
            this.CompactBitmask = compactBitmask;
            this.ServerlessCompatible = serverlessCompatible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureFlags" /> class.
        /// </summary>
        public FeatureFlags()
        {
        }

    }
}