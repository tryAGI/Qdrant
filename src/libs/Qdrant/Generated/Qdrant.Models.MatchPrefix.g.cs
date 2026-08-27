
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Match keyword values that start with the given string.<br/>
    /// Byte-wise (hence, for valid UTF-8, character-wise) and case-sensitive, consistent with exact keyword matching. Served efficiently by a keyword index created with the `prefix` option.
    /// </summary>
    public sealed partial class MatchPrefix
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchPrefix" /> class.
        /// </summary>
        /// <param name="prefix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatchPrefix(
            string prefix)
        {
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchPrefix" /> class.
        /// </summary>
        public MatchPrefix()
        {
        }

    }
}