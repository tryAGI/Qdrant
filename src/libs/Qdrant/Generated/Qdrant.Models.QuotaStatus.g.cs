
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Quota configuration in effect, and how close each peer is to it.<br/>
    /// The configuration is cluster-wide; the utilization is not. `usage` is the node that served the request, and `peers` is what every peer that answered reports about itself — memory and disk are node-local, so one peer being under its limit says nothing about the others.
    /// </summary>
    public sealed partial class QuotaStatus
    {
        /// <summary>
        /// Cluster-wide limits on node resources.<br/>
        /// An unset limit means the corresponding resource is not capped. Limits are only enforced while `enabled` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.QuotaConfig Config { get; set; }

        /// <summary>
        /// Utilization of the quota-managed resources **on this node alone** — memory and disk are node-local, so a peer under its limit says nothing about the rest of the cluster.<br/>
        /// A field is `null` when the platform does not expose the underlying stat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.QuotaUsage Usage { get; set; }

        /// <summary>
        /// Utilization reported by each peer, keyed by peer ID, including the one that served the request.<br/>
        /// Only peers that answered are listed: a peer missing from the map could not be reached, which is itself worth seeing. Absent entirely outside distributed mode, where there are no peers to ask.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peers")]
        public global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerQuotaUsage>? Peers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaStatus" /> class.
        /// </summary>
        /// <param name="config">
        /// Cluster-wide limits on node resources.<br/>
        /// An unset limit means the corresponding resource is not capped. Limits are only enforced while `enabled` is true.
        /// </param>
        /// <param name="usage">
        /// Utilization of the quota-managed resources **on this node alone** — memory and disk are node-local, so a peer under its limit says nothing about the rest of the cluster.<br/>
        /// A field is `null` when the platform does not expose the underlying stat.
        /// </param>
        /// <param name="peers">
        /// Utilization reported by each peer, keyed by peer ID, including the one that served the request.<br/>
        /// Only peers that answered are listed: a peer missing from the map could not be reached, which is itself worth seeing. Absent entirely outside distributed mode, where there are no peers to ask.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuotaStatus(
            global::Qdrant.QuotaConfig config,
            global::Qdrant.QuotaUsage usage,
            global::System.Collections.Generic.Dictionary<string, global::Qdrant.PeerQuotaUsage>? peers)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Peers = peers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaStatus" /> class.
        /// </summary>
        public QuotaStatus()
        {
        }

    }
}