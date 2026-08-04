
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Metadata to update for the collection. If provided, this will merge with existing metadata. Individual keys can be removed by setting their value to `null`.
    /// </summary>
    public sealed partial class UpdateCollectionMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}