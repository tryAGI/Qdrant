
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DisabledStemmerParams
    {
        /// <summary>
        /// Tag selecting the explicit "no stemming" algorithm.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.NoStemmerJsonConverter))]
        public global::Qdrant.NoStemmer Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DisabledStemmerParams" /> class.
        /// </summary>
        /// <param name="type">
        /// Tag selecting the explicit "no stemming" algorithm.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DisabledStemmerParams(
            global::Qdrant.NoStemmer type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisabledStemmerParams" /> class.
        /// </summary>
        public DisabledStemmerParams()
        {
        }

    }
}