
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatetimeIndexParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.DatetimeIndexTypeJsonConverter))]
        public global::Qdrant.DatetimeIndexType Type { get; set; }

        /// <summary>
        /// If true - use this key to organize storage of the collection data. This option assumes that this key will be used in majority of filtered requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_principal")]
        public bool? IsPrincipal { get; set; }

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
        /// Initializes a new instance of the <see cref="DatetimeIndexParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="isPrincipal">
        /// If true - use this key to organize storage of the collection data. This option assumes that this key will be used in majority of filtered requests.
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
        public DatetimeIndexParams(
            global::Qdrant.DatetimeIndexType type,
            bool? isPrincipal,
            global::Qdrant.Memory? memory,
            bool? enableHnsw)
        {
            this.Type = type;
            this.IsPrincipal = isPrincipal;
            this.Memory = memory;
            this.EnableHnsw = enableHnsw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeIndexParams" /> class.
        /// </summary>
        public DatetimeIndexParams()
        {
        }

    }
}