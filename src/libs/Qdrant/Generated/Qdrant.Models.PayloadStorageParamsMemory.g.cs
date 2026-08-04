
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Memory placement of the payload storage. Overrides the deprecated `on_disk_payload` flag if both are set. `pinned` is not supported for payload storage. Default: `cold` (`cached` if `on_disk_payload` is set to false).
    /// </summary>
    public sealed partial class PayloadStorageParamsMemory
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}