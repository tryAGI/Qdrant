
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Match keyword values that contain the given string.<br/>
    /// Byte-wise (hence, for valid UTF-8, character-wise) and case-sensitive, consistent with exact keyword and prefix matching. Served by a keyword index with the `prefix` option, through a scan of its key dictionary; without one, falls back to reading the payload.
    /// </summary>
    public sealed partial class MatchSubstring
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("substring")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Substring { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchSubstring" /> class.
        /// </summary>
        /// <param name="substring"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatchSubstring(
            string substring)
        {
            this.Substring = substring ?? throw new global::System.ArgumentNullException(nameof(substring));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchSubstring" /> class.
        /// </summary>
        public MatchSubstring()
        {
        }

    }
}