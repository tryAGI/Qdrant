
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
        /// Allow the batched io_uring-based HNSW graph search. When disabled, the HNSW graph is *never* opened on io_uring. When enabled, the graph backend is decided based on `storage.performance.io_uring` option and links placement.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async_hnsw_graph")]
        public bool? AsyncHnswGraph { get; set; }

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
        /// Create Blobstore-backed storages (payload storage, appendable field indexes, sparse vectors) in the append-only Logstore mode. Gates creation only: an existing storage keeps its persisted mode, and both modes are always readable.<br/>
        /// Implies [`Self::append_only_mutations`], enforced by [`init_feature_flags`].<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("append_only_storages")]
        public bool? AppendOnlyStorages { get; set; }

        /// <summary>
        /// Transfer points as storage-native bytes (raw points), for every collection rather than only those whose vector storage would lose precision in a decode-encode round-trip (TurboQuant).<br/>
        /// Read on the sending side only, where the transfer batch is prepared: nodes accept raw points regardless.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_raw_points")]
        public bool? TransferRawPoints { get; set; }

        /// <summary>
        /// Send the payload of a raw point as the byte blob it is stored as, so the sending node does not parse it and neither node builds a protobuf value tree for it. The receiving node still parses the blob, once, when the operation is applied. Only has an effect on points transferred raw, see [`Self::transfer_raw_points`].<br/>
        /// Read on the sending side only: nodes accept raw payloads regardless.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_raw_payloads")]
        public bool? TransferRawPayloads { get; set; }

        /// <summary>
        /// Serverless-compatible deployment mode. Automatically enables [`Self::write_segment_manifest`], [`Self::append_only_mutations`], [`Self::compact_bitmask`] and [`Self::append_only_storages`].<br/>
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
        /// <param name="asyncHnswGraph">
        /// Allow the batched io_uring-based HNSW graph search. When disabled, the HNSW graph is *never* opened on io_uring. When enabled, the graph backend is decided based on `storage.performance.io_uring` option and links placement.<br/>
        /// Default Value: false
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
        /// <param name="appendOnlyStorages">
        /// Create Blobstore-backed storages (payload storage, appendable field indexes, sparse vectors) in the append-only Logstore mode. Gates creation only: an existing storage keeps its persisted mode, and both modes are always readable.<br/>
        /// Implies [`Self::append_only_mutations`], enforced by [`init_feature_flags`].<br/>
        /// Default Value: false
        /// </param>
        /// <param name="transferRawPoints">
        /// Transfer points as storage-native bytes (raw points), for every collection rather than only those whose vector storage would lose precision in a decode-encode round-trip (TurboQuant).<br/>
        /// Read on the sending side only, where the transfer batch is prepared: nodes accept raw points regardless.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="transferRawPayloads">
        /// Send the payload of a raw point as the byte blob it is stored as, so the sending node does not parse it and neither node builds a protobuf value tree for it. The receiving node still parses the blob, once, when the operation is applied. Only has an effect on points transferred raw, see [`Self::transfer_raw_points`].<br/>
        /// Read on the sending side only: nodes accept raw payloads regardless.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="serverlessCompatible">
        /// Serverless-compatible deployment mode. Automatically enables [`Self::write_segment_manifest`], [`Self::append_only_mutations`], [`Self::compact_bitmask`] and [`Self::append_only_storages`].<br/>
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
            bool? asyncHnswGraph,
            bool? writeSegmentManifest,
            bool? appendOnlyMutations,
            bool? compactBitmask,
            bool? appendOnlyStorages,
            bool? transferRawPoints,
            bool? transferRawPayloads,
            bool? serverlessCompatible)
        {
            this.All = all;
            this.IncrementalHnswBuilding = incrementalHnswBuilding;
            this.AppendableQuantization = appendableQuantization;
            this.SingleFileMmapVectorStorage = singleFileMmapVectorStorage;
            this.AsyncPayloadStorage = asyncPayloadStorage;
            this.AsyncHnswGraph = asyncHnswGraph;
            this.WriteSegmentManifest = writeSegmentManifest;
            this.AppendOnlyMutations = appendOnlyMutations;
            this.CompactBitmask = compactBitmask;
            this.AppendOnlyStorages = appendOnlyStorages;
            this.TransferRawPoints = transferRawPoints;
            this.TransferRawPayloads = transferRawPayloads;
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