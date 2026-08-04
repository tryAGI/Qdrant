
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Which of the enforced limits a node is currently refusing work over.<br/>
    /// Reported per resource because they are freed by different actions: disk by deleting or optimizing, memory by unloading. A single flag would not say which one to go and fix.<br/>
    /// `true` outlasts the reading that caused it: a resource that reaches its limit stays flagged until it has fallen a margin below, so that one resting near the limit does not flip the node in and out of service. Expect to see it set while the reported utilization is already back under the configured limit.<br/>
    /// A field is `null` when the node is not enforcing that resource — the quota is disabled, no limit is set for it, or it cannot be measured here. That is deliberately distinct from `false`: a resource that can never trip must not be reported as one that is within its limits, or it invites an alert that can never fire.
    /// </summary>
    public sealed partial class QuotaExceeded
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resident_memory")]
        public bool? ResidentMemory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_usage")]
        public bool? DiskUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaExceeded" /> class.
        /// </summary>
        /// <param name="residentMemory"></param>
        /// <param name="diskUsage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuotaExceeded(
            bool? residentMemory,
            bool? diskUsage)
        {
            this.ResidentMemory = residentMemory;
            this.DiskUsage = diskUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaExceeded" /> class.
        /// </summary>
        public QuotaExceeded()
        {
        }

    }
}