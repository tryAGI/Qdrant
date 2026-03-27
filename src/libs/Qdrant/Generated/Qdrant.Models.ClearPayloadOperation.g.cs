
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClearPayloadOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_payload")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.PointsSelectorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.PointsSelector ClearPayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearPayloadOperation" /> class.
        /// </summary>
        /// <param name="clearPayload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClearPayloadOperation(
            global::Qdrant.PointsSelector clearPayload)
        {
            this.ClearPayload = clearPayload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearPayloadOperation" /> class.
        /// </summary>
        public ClearPayloadOperation()
        {
        }
    }
}