
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Update params for HNSW index. If empty object - it will be unset.
    /// </summary>
    public sealed partial class VectorParamsDiffHnswConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}