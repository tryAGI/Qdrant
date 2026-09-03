
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Smallest of the given expressions. Requires at least one operand.
    /// </summary>
    public sealed partial class MinExpression
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Qdrant.Expression> Min { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MinExpression" /> class.
        /// </summary>
        /// <param name="min"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MinExpression(
            global::System.Collections.Generic.IList<global::Qdrant.Expression> min)
        {
            this.Min = min ?? throw new global::System.ArgumentNullException(nameof(min));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinExpression" /> class.
        /// </summary>
        public MinExpression()
        {
        }

    }
}