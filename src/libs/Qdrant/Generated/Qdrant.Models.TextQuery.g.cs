
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Rank by BM25 over the text index of the payload field named by `using`, which must have `scoring` set. A point scores when it holds any of the query's terms: required or excluded terms belong in the request's `filter`.
    /// </summary>
    public sealed partial class TextQuery
    {
        /// <summary>
        /// The text to search for, or the text with scorer parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.TextInterfaceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.TextInterface Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextQuery" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to search for, or the text with scorer parameters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextQuery(
            global::Qdrant.TextInterface text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextQuery" /> class.
        /// </summary>
        public TextQuery()
        {
        }

    }
}