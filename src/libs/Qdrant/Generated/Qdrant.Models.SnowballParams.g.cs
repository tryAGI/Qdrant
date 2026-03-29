
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnowballParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.SnowballTypeJsonConverter))]
        public global::Qdrant.SnowballType Type { get; set; }

        /// <summary>
        /// Languages supported by snowball stemmer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.SnowballLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.SnowballLanguage Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnowballParams" /> class.
        /// </summary>
        /// <param name="language">
        /// Languages supported by snowball stemmer.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnowballParams(
            global::Qdrant.SnowballLanguage language,
            global::Qdrant.SnowballType type)
        {
            this.Type = type;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnowballParams" /> class.
        /// </summary>
        public SnowballParams()
        {
        }
    }
}