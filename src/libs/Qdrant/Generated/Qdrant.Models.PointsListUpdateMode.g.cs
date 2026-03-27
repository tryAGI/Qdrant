
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Mode of the upsert operation: insert_only, upsert (default), update_only
    /// </summary>
    public sealed partial class PointsListUpdateMode
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}