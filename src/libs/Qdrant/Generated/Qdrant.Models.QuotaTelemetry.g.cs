
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// What a node reports about the quota it is enforcing.<br/>
    /// Carries the verdict rather than the raw utilization, because the point of reporting it is to know whether this node is currently refusing writes — which depends on the limits as well as the readings.
    /// </summary>
    public sealed partial class QuotaTelemetry
    {
        /// <summary>
        /// Cluster-wide limits on node resources.<br/>
        /// An unset limit means the corresponding resource is not capped. Limits are only enforced while `enabled` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.QuotaConfig Config { get; set; }

        /// <summary>
        /// Which of the enforced limits a node is currently refusing work over.<br/>
        /// Reported per resource because they are freed by different actions: disk by deleting or optimizing, memory by unloading. A single flag would not say which one to go and fix.<br/>
        /// `true` outlasts the reading that caused it: a resource that reaches its limit stays flagged until it has fallen a margin below, so that one resting near the limit does not flip the node in and out of service. Expect to see it set while the reported utilization is already back under the configured limit.<br/>
        /// A field is `null` when the node is not enforcing that resource — the quota is disabled, no limit is set for it, or it cannot be measured here. That is deliberately distinct from `false`: a resource that can never trip must not be reported as one that is within its limits, or it invites an alert that can never fire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exceeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.QuotaExceeded Exceeded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaTelemetry" /> class.
        /// </summary>
        /// <param name="config">
        /// Cluster-wide limits on node resources.<br/>
        /// An unset limit means the corresponding resource is not capped. Limits are only enforced while `enabled` is true.
        /// </param>
        /// <param name="exceeded">
        /// Which of the enforced limits a node is currently refusing work over.<br/>
        /// Reported per resource because they are freed by different actions: disk by deleting or optimizing, memory by unloading. A single flag would not say which one to go and fix.<br/>
        /// `true` outlasts the reading that caused it: a resource that reaches its limit stays flagged until it has fallen a margin below, so that one resting near the limit does not flip the node in and out of service. Expect to see it set while the reported utilization is already back under the configured limit.<br/>
        /// A field is `null` when the node is not enforcing that resource — the quota is disabled, no limit is set for it, or it cannot be measured here. That is deliberately distinct from `false`: a resource that can never trip must not be reported as one that is within its limits, or it invites an alert that can never fire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuotaTelemetry(
            global::Qdrant.QuotaConfig config,
            global::Qdrant.QuotaExceeded exceeded)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Exceeded = exceeded ?? throw new global::System.ArgumentNullException(nameof(exceeded));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaTelemetry" /> class.
        /// </summary>
        public QuotaTelemetry()
        {
        }

    }
}