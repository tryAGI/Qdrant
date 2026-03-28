
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiscoverInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.VectorInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.VectorInput Target { get; set; }

        /// <summary>
        /// Search space will be constrained by these pairs of vectors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.ContextPair, global::System.Collections.Generic.IList<global::Qdrant.ContextPair>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.IList<global::Qdrant.ContextPair>, object> Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverInput" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="context">
        /// Search space will be constrained by these pairs of vectors
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiscoverInput(
            global::Qdrant.VectorInput target,
            global::Qdrant.AnyOf<global::Qdrant.ContextPair, global::System.Collections.Generic.IList<global::Qdrant.ContextPair>, object> context)
        {
            this.Target = target;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverInput" /> class.
        /// </summary>
        public DiscoverInput()
        {
        }
    }
}