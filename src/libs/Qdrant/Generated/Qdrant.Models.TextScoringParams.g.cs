
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Parameters of ranking over a text index. The index records the length of each document, which BM25 normalizes by. `k1` and `b` are set per query.
    /// </summary>
    public sealed partial class TextScoringParams
    {
        /// <summary>
        /// How a text index ranks documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.TextScoringTypeJsonConverter))]
        public global::Qdrant.TextScoringType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextScoringParams" /> class.
        /// </summary>
        /// <param name="type">
        /// How a text index ranks documents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextScoringParams(
            global::Qdrant.TextScoringType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextScoringParams" /> class.
        /// </summary>
        public TextScoringParams()
        {
        }

    }
}