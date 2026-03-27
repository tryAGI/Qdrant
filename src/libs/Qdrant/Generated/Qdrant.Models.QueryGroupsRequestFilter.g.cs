
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Filter conditions - return only those points that satisfy the specified conditions.
    /// </summary>
    public sealed partial class QueryGroupsRequestFilter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}