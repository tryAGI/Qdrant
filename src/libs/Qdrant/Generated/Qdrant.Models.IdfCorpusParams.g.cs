
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// IDF statistics computed over the points matching a corpus filter.
    /// </summary>
    public sealed partial class IdfCorpusParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.Filter Corpus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdfCorpusParams" /> class.
        /// </summary>
        /// <param name="corpus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdfCorpusParams(
            global::Qdrant.Filter corpus)
        {
            this.Corpus = corpus ?? throw new global::System.ArgumentNullException(nameof(corpus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdfCorpusParams" /> class.
        /// </summary>
        public IdfCorpusParams()
        {
        }

    }
}