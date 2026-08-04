
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Memory placement of the original vector storage. Overrides the deprecated `on_disk` flag if both are set. `pinned` is not supported for dense vector storage.
    /// </summary>
    public sealed partial class VectorParamsDiffMemory
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}