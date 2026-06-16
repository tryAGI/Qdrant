
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Configuration for creating a new dense named vector.<br/>
    /// Only includes properties that define the vector space and cannot be changed after creation. Storage type, index type, and quantization are inferred.
    /// </summary>
    public sealed partial class DenseVectorConfig
    {
        /// <summary>
        /// Dimensionality of the vectors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// Type of internal tags, build from payload Distance function types used to compare vectors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.DistanceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.Distance Distance { get; set; }

        /// <summary>
        /// Configuration for multi-vector points (e.g., ColBERT)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multivector_config")]
        public global::Qdrant.MultiVectorConfig? MultivectorConfig { get; set; }

        /// <summary>
        /// Element storage type (Float32, Float16, Uint8, Turbo4)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datatype")]
        public global::Qdrant.VectorStorageDatatype? Datatype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DenseVectorConfig" /> class.
        /// </summary>
        /// <param name="size">
        /// Dimensionality of the vectors
        /// </param>
        /// <param name="distance">
        /// Type of internal tags, build from payload Distance function types used to compare vectors
        /// </param>
        /// <param name="multivectorConfig">
        /// Configuration for multi-vector points (e.g., ColBERT)
        /// </param>
        /// <param name="datatype">
        /// Element storage type (Float32, Float16, Uint8, Turbo4)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DenseVectorConfig(
            int size,
            global::Qdrant.Distance distance,
            global::Qdrant.MultiVectorConfig? multivectorConfig,
            global::Qdrant.VectorStorageDatatype? datatype)
        {
            this.Size = size;
            this.Distance = distance;
            this.MultivectorConfig = multivectorConfig;
            this.Datatype = datatype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DenseVectorConfig" /> class.
        /// </summary>
        public DenseVectorConfig()
        {
        }

    }
}