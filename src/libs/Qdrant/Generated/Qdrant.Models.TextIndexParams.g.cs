
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextIndexParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.TextIndexTypeJsonConverter))]
        public global::Qdrant.TextIndexType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.TokenizerTypeJsonConverter))]
        public global::Qdrant.TokenizerType? Tokenizer { get; set; }

        /// <summary>
        /// Minimum characters to be tokenized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_token_len")]
        public int? MinTokenLen { get; set; }

        /// <summary>
        /// Maximum characters to be tokenized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_token_len")]
        public int? MaxTokenLen { get; set; }

        /// <summary>
        /// If true, lowercase all tokens. Default: true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lowercase")]
        public bool? Lowercase { get; set; }

        /// <summary>
        /// If true, normalize tokens by folding accented characters to ASCII (e.g., "ação" -&gt; "acao"). Default: false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ascii_folding")]
        public bool? AsciiFolding { get; set; }

        /// <summary>
        /// If true, support phrase matching. Default: false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phrase_matching")]
        public bool? PhraseMatching { get; set; }

        /// <summary>
        /// Ignore this set of tokens. Can select from predefined languages and/or provide a custom set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwords")]
        public global::Qdrant.StopwordsInterface? Stopwords { get; set; }

        /// <summary>
        /// Deprecated: use `memory` instead. If true, store the index on disk. Default: false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_disk")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? OnDisk { get; set; }

        /// <summary>
        /// Memory placement of the index. Overrides the deprecated `on_disk` flag if both are set. Default: `pinned` (`cold` if `on_disk` is set to true).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public global::Qdrant.Memory? Memory { get; set; }

        /// <summary>
        /// Algorithm for stemming. Default: disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stemmer")]
        public global::Qdrant.StemmingAlgorithm? Stemmer { get; set; }

        /// <summary>
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_hnsw")]
        public bool? EnableHnsw { get; set; }

        /// <summary>
        /// Enable ranking points by BM25 over this field; `true` for the defaults. Changing it rebuilds the index. Default: disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring")]
        public global::Qdrant.TextScoringInterface? Scoring { get; set; }

        /// <summary>
        /// Index every object of this array as a separate entry, e.g. `offers` for the field `offers[].title`. The field must be inside the array's elements. Every query on the field, not only nested filters, treats each element as its own document: a condition matches a point when a single element matches it, and BM25 scores elements separately. `is_empty` on the field matches a point when one of its elements lacks the field, and never a point without elements. Default: disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nested")]
        public string? Nested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextIndexParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="tokenizer"></param>
        /// <param name="minTokenLen">
        /// Minimum characters to be tokenized.
        /// </param>
        /// <param name="maxTokenLen">
        /// Maximum characters to be tokenized.
        /// </param>
        /// <param name="lowercase">
        /// If true, lowercase all tokens. Default: true.
        /// </param>
        /// <param name="asciiFolding">
        /// If true, normalize tokens by folding accented characters to ASCII (e.g., "ação" -&gt; "acao"). Default: false.
        /// </param>
        /// <param name="phraseMatching">
        /// If true, support phrase matching. Default: false.
        /// </param>
        /// <param name="stopwords">
        /// Ignore this set of tokens. Can select from predefined languages and/or provide a custom set.
        /// </param>
        /// <param name="memory">
        /// Memory placement of the index. Overrides the deprecated `on_disk` flag if both are set. Default: `pinned` (`cold` if `on_disk` is set to true).
        /// </param>
        /// <param name="stemmer">
        /// Algorithm for stemming. Default: disabled.
        /// </param>
        /// <param name="enableHnsw">
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </param>
        /// <param name="scoring">
        /// Enable ranking points by BM25 over this field; `true` for the defaults. Changing it rebuilds the index. Default: disabled.
        /// </param>
        /// <param name="nested">
        /// Index every object of this array as a separate entry, e.g. `offers` for the field `offers[].title`. The field must be inside the array's elements. Every query on the field, not only nested filters, treats each element as its own document: a condition matches a point when a single element matches it, and BM25 scores elements separately. `is_empty` on the field matches a point when one of its elements lacks the field, and never a point without elements. Default: disabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextIndexParams(
            global::Qdrant.TextIndexType type,
            global::Qdrant.TokenizerType? tokenizer,
            int? minTokenLen,
            int? maxTokenLen,
            bool? lowercase,
            bool? asciiFolding,
            bool? phraseMatching,
            global::Qdrant.StopwordsInterface? stopwords,
            global::Qdrant.Memory? memory,
            global::Qdrant.StemmingAlgorithm? stemmer,
            bool? enableHnsw,
            global::Qdrant.TextScoringInterface? scoring,
            string? nested)
        {
            this.Type = type;
            this.Tokenizer = tokenizer;
            this.MinTokenLen = minTokenLen;
            this.MaxTokenLen = maxTokenLen;
            this.Lowercase = lowercase;
            this.AsciiFolding = asciiFolding;
            this.PhraseMatching = phraseMatching;
            this.Stopwords = stopwords;
            this.Memory = memory;
            this.Stemmer = stemmer;
            this.EnableHnsw = enableHnsw;
            this.Scoring = scoring;
            this.Nested = nested;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextIndexParams" /> class.
        /// </summary>
        public TextIndexParams()
        {
        }

    }
}