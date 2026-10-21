
#nullable enable

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Bm25Scoring
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bm25")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.Bm25Params Bm25 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Bm25Scoring" /> class.
        /// </summary>
        /// <param name="bm25"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Bm25Scoring(
            global::Qdrant.Bm25Params bm25)
        {
            this.Bm25 = bm25 ?? throw new global::System.ArgumentNullException(nameof(bm25));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bm25Scoring" /> class.
        /// </summary>
        public Bm25Scoring()
        {
        }

    }
}