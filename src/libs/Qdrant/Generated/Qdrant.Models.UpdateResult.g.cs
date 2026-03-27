
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateResult
    {
        /// <summary>
        /// Sequential number of the operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_id")]
        public int? OperationId { get; set; }

        /// <summary>
        /// `Acknowledged` - Request is saved to WAL and will be process in a queue. `Completed` - Request is completed, changes are actual. `WaitTimeout` - Request is waiting for timeout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.UpdateStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.UpdateStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResult" /> class.
        /// </summary>
        /// <param name="operationId">
        /// Sequential number of the operation
        /// </param>
        /// <param name="status">
        /// `Acknowledged` - Request is saved to WAL and will be process in a queue. `Completed` - Request is completed, changes are actual. `WaitTimeout` - Request is waiting for timeout.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResult(
            global::Qdrant.UpdateStatus status,
            int? operationId)
        {
            this.Status = status;
            this.OperationId = operationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResult" /> class.
        /// </summary>
        public UpdateResult()
        {
        }
    }
}