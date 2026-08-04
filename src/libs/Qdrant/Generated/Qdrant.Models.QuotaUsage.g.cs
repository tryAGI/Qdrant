
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Utilization of the quota-managed resources **on this node alone** — memory and disk are node-local, so a peer under its limit says nothing about the rest of the cluster.<br/>
    /// A field is `null` when the platform does not expose the underlying stat.
    /// </summary>
    public sealed partial class QuotaUsage
    {
        /// <summary>
        /// Resident memory of this node's process, as a percentage of the memory available to it (cgroup limit if one applies, else total system memory).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resident_memory_percent")]
        public byte? ResidentMemoryPercent { get; set; }

        /// <summary>
        /// Used space of this node's storage filesystem, as a percentage of its capacity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_usage_percent")]
        public byte? DiskUsagePercent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaUsage" /> class.
        /// </summary>
        /// <param name="residentMemoryPercent">
        /// Resident memory of this node's process, as a percentage of the memory available to it (cgroup limit if one applies, else total system memory).
        /// </param>
        /// <param name="diskUsagePercent">
        /// Used space of this node's storage filesystem, as a percentage of its capacity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuotaUsage(
            byte? residentMemoryPercent,
            byte? diskUsagePercent)
        {
            this.ResidentMemoryPercent = residentMemoryPercent;
            this.DiskUsagePercent = diskUsagePercent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaUsage" /> class.
        /// </summary>
        public QuotaUsage()
        {
        }

    }
}