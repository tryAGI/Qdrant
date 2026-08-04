
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Which population sparse vector IDF statistics are computed over. By default (or with explicit `"global"`) statistics are collection-wide. Only applicable to sparse vectors with the IDF modifier enabled.
    /// </summary>
    public sealed partial class SearchParamsIdf
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}