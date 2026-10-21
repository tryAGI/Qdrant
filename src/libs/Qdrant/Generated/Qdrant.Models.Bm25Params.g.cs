
#nullable enable

namespace Qdrant
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Bm25Params
    {
        /// <summary>
        /// Term frequency saturation. Default is 1.2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k")]
        public float? K { get; set; }

        /// <summary>
        /// Document length normalization, from 0 (none) to 1 (full). Default is 0.75.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b")]
        public float? B { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Bm25Params" /> class.
        /// </summary>
        /// <param name="k">
        /// Term frequency saturation. Default is 1.2.
        /// </param>
        /// <param name="b">
        /// Document length normalization, from 0 (none) to 1 (full). Default is 0.75.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Bm25Params(
            float? k,
            float? b)
        {
            this.K = k;
            this.B = b;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bm25Params" /> class.
        /// </summary>
        public Bm25Params()
        {
        }

    }
}