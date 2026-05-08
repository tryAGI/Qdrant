
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Configuration for multi-vector points (e.g., ColBERT)
    /// </summary>
    public sealed partial class DenseVectorConfigMultivectorConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}