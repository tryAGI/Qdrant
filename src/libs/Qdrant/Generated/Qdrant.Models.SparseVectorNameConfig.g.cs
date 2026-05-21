
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Wrapper for sparse vector creation config.
    /// </summary>
    public sealed partial class SparseVectorNameConfig
    {
        /// <summary>
        /// Configuration for creating a new sparse named vector.<br/>
        /// Only includes properties that define the vector space and cannot be changed after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.SparseVectorConfig Sparse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorNameConfig" /> class.
        /// </summary>
        /// <param name="sparse">
        /// Configuration for creating a new sparse named vector.<br/>
        /// Only includes properties that define the vector space and cannot be changed after creation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseVectorNameConfig(
            global::Qdrant.SparseVectorConfig sparse)
        {
            this.Sparse = sparse ?? throw new global::System.ArgumentNullException(nameof(sparse));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVectorNameConfig" /> class.
        /// </summary>
        public SparseVectorNameConfig()
        {
        }

    }
}