
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Cluster-wide limits on node resources.<br/>
    /// An unset limit means the corresponding resource is not capped. Limits are only enforced while `enabled` is true.
    /// </summary>
    public sealed partial class QuotaConfig
    {
        /// <summary>
        /// Whether the limits below are enforced.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Reject memory-consuming updates once process resident memory reaches this percentage of total system memory (or of the cgroup limit, if one applies).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_resident_memory_percent")]
        public byte? MaxResidentMemoryPercent { get; set; }

        /// <summary>
        /// Reject disk-consuming updates once the filesystem hosting the storage directory is filled to this percentage of its capacity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_disk_usage_percent")]
        public byte? MaxDiskUsagePercent { get; set; }

        /// <summary>
        /// How many percentage points below its limit a resource has to fall before this node starts accepting work again.<br/>
        /// Without a margin, a resource resting on its limit crosses it in both directions on the noise between two readings, putting the node in and out of service each time — and restarting a shard recovery with it. Raise it where usage is volatile; `0` disables the margin and releases as soon as usage is back under the limit.<br/>
        /// Unset leaves the built-in default in force, so a config written today does not pin a number that a later release may want to revise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_margin_percent")]
        public byte? ReleaseMarginPercent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the limits below are enforced.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxResidentMemoryPercent">
        /// Reject memory-consuming updates once process resident memory reaches this percentage of total system memory (or of the cgroup limit, if one applies).
        /// </param>
        /// <param name="maxDiskUsagePercent">
        /// Reject disk-consuming updates once the filesystem hosting the storage directory is filled to this percentage of its capacity.
        /// </param>
        /// <param name="releaseMarginPercent">
        /// How many percentage points below its limit a resource has to fall before this node starts accepting work again.<br/>
        /// Without a margin, a resource resting on its limit crosses it in both directions on the noise between two readings, putting the node in and out of service each time — and restarting a shard recovery with it. Raise it where usage is volatile; `0` disables the margin and releases as soon as usage is back under the limit.<br/>
        /// Unset leaves the built-in default in force, so a config written today does not pin a number that a later release may want to revise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuotaConfig(
            bool? enabled,
            byte? maxResidentMemoryPercent,
            byte? maxDiskUsagePercent,
            byte? releaseMarginPercent)
        {
            this.Enabled = enabled;
            this.MaxResidentMemoryPercent = maxResidentMemoryPercent;
            this.MaxDiskUsagePercent = maxDiskUsagePercent;
            this.ReleaseMarginPercent = releaseMarginPercent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaConfig" /> class.
        /// </summary>
        public QuotaConfig()
        {
        }

    }
}