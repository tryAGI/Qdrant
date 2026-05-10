
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Wrapper for dense vector creation config.
    /// </summary>
    public sealed partial class DenseVectorNameConfig
    {
        /// <summary>
        /// Configuration for creating a new dense named vector.<br/>
        /// Only includes properties that define the vector space and cannot be changed after creation. Storage type, index type, and quantization are inferred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dense")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.DenseVectorConfig Dense { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DenseVectorNameConfig" /> class.
        /// </summary>
        /// <param name="dense">
        /// Configuration for creating a new dense named vector.<br/>
        /// Only includes properties that define the vector space and cannot be changed after creation. Storage type, index type, and quantization are inferred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DenseVectorNameConfig(
            global::Qdrant.DenseVectorConfig dense)
        {
            this.Dense = dense ?? throw new global::System.ArgumentNullException(nameof(dense));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DenseVectorNameConfig" /> class.
        /// </summary>
        public DenseVectorNameConfig()
        {
        }

    }
}