
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UuidIndexParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.UuidIndexTypeJsonConverter))]
        public global::Qdrant.UuidIndexType Type { get; set; }

        /// <summary>
        /// If true - used for tenant optimization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_tenant")]
        public bool? IsTenant { get; set; }

        /// <summary>
        /// Deprecated: use `memory` instead. If true, store the index on disk. Default: false.
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
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_hnsw")]
        public bool? EnableHnsw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UuidIndexParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="isTenant">
        /// If true - used for tenant optimization.
        /// </param>
        /// <param name="memory">
        /// Memory placement of the index. Overrides the deprecated `on_disk` flag if both are set. Default: `pinned` (`cold` if `on_disk` is set to true).
        /// </param>
        /// <param name="enableHnsw">
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UuidIndexParams(
            global::Qdrant.UuidIndexType type,
            bool? isTenant,
            global::Qdrant.Memory? memory,
            bool? enableHnsw)
        {
            this.Type = type;
            this.IsTenant = isTenant;
            this.Memory = memory;
            this.EnableHnsw = enableHnsw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UuidIndexParams" /> class.
        /// </summary>
        public UuidIndexParams()
        {
        }

    }
}