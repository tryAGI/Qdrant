
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Memory placement of the original vector storage. Overrides the deprecated `on_disk` flag if both are set. `pinned` is not supported for dense vector storage. Default: `cached` (`cold` if `on_disk` is set to true).
    /// </summary>
    public sealed partial class VectorParamsMemory
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}