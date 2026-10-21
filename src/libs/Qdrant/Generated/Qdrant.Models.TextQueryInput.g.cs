
#nullable enable

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextQueryInput
    {
        /// <summary>
        /// Text to search for, tokenized by the field's text index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Parameters of the scorer, keyed by its name. They must match the `scoring` type of the field's text index. If absent, the scorer runs with its defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring")]
        public global::Qdrant.TextQueryScoring? Scoring { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextQueryInput" /> class.
        /// </summary>
        /// <param name="query">
        /// Text to search for, tokenized by the field's text index.
        /// </param>
        /// <param name="scoring">
        /// Parameters of the scorer, keyed by its name. They must match the `scoring` type of the field's text index. If absent, the scorer runs with its defaults.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextQueryInput(
            string query,
            global::Qdrant.TextQueryScoring? scoring)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Scoring = scoring;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextQueryInput" /> class.
        /// </summary>
        public TextQueryInput()
        {
        }

    }
}