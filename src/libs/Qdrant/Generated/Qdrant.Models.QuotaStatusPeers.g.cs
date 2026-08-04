
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Utilization reported by each peer, keyed by peer ID, including the one that served the request.<br/>
    /// Only peers that answered are listed: a peer missing from the map could not be reached, which is itself worth seeing. Absent entirely outside distributed mode, where there are no peers to ask.
    /// </summary>
    public sealed partial class QuotaStatusPeers
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}