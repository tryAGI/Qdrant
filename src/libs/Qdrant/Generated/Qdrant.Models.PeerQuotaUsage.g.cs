
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// What one peer reports about the quota it is enforcing.
    /// </summary>
    public sealed partial class PeerQuotaUsage
    {
        /// <summary>
        /// Whether this peer is at or over one of the enforced limits, and so is currently refusing updates. Always false while the quota is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exceeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Exceeded { get; set; }

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
        /// Initializes a new instance of the <see cref="PeerQuotaUsage" /> class.
        /// </summary>
        /// <param name="exceeded">
        /// Whether this peer is at or over one of the enforced limits, and so is currently refusing updates. Always false while the quota is disabled.
        /// </param>
        /// <param name="residentMemoryPercent">
        /// Resident memory of this node's process, as a percentage of the memory available to it (cgroup limit if one applies, else total system memory).
        /// </param>
        /// <param name="diskUsagePercent">
        /// Used space of this node's storage filesystem, as a percentage of its capacity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PeerQuotaUsage(
            bool exceeded,
            byte? residentMemoryPercent,
            byte? diskUsagePercent)
        {
            this.Exceeded = exceeded;
            this.ResidentMemoryPercent = residentMemoryPercent;
            this.DiskUsagePercent = diskUsagePercent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeerQuotaUsage" /> class.
        /// </summary>
        public PeerQuotaUsage()
        {
        }

    }
}