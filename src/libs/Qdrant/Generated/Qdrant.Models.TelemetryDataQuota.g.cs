
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Resource quota this node is enforcing, and whether it is currently over it. The config is whatever this node last persisted, so a peer that missed a consensus update reports what it is actually applying rather than what the cluster agreed on. Absent for a token without global access, which `GET /quotas` requires as well.
    /// </summary>
    public sealed partial class TelemetryDataQuota
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}