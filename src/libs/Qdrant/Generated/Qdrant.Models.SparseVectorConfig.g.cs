
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Configuration for creating a new sparse named vector.<br/>
    /// Only includes properties that define the vector space and cannot be changed after creation.
    /// </summary>
    public sealed partial class SparseVectorConfig
    {
        /// <summary>
        /// Value modifier for sparse vectors (e.g., IDF)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifier")]
        public global::Qdrant.Modifier? Modifier { get; set; }

        /// <summary>
        /// Datatype used to store weights in the index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datatype")]
        public global::Qdrant.VectorStorageDatatype? Datatype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorConfig" /> class.
        /// </summary>
        /// <param name="modifier">
        /// Value modifier for sparse vectors (e.g., IDF)
        /// </param>
        /// <param name="datatype">
        /// Datatype used to store weights in the index
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseVectorConfig(
            global::Qdrant.Modifier? modifier,
            global::Qdrant.VectorStorageDatatype? datatype)
        {
            this.Modifier = modifier;
            this.Datatype = datatype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorConfig" /> class.
        /// </summary>
        public SparseVectorConfig()
        {
        }

    }
}