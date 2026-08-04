
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Memory placement of the index. Overrides the deprecated `on_disk` flag if both are set. Default: `pinned` (`cold` if `on_disk` is set to true).
    /// </summary>
    public sealed partial class SparseIndexParamsMemory
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}