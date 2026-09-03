
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Largest of the given expressions. Requires at least one operand.
    /// </summary>
    public sealed partial class MaxExpression
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Qdrant.Expression> Max { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaxExpression" /> class.
        /// </summary>
        /// <param name="max"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MaxExpression(
            global::System.Collections.Generic.IList<global::Qdrant.Expression> max)
        {
            this.Max = max ?? throw new global::System.ArgumentNullException(nameof(max));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaxExpression" /> class.
        /// </summary>
        public MaxExpression()
        {
        }

    }
}