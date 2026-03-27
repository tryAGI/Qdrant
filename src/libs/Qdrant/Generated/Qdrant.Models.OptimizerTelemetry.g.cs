
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizerTelemetry
    {
        /// <summary>
        /// Current state of the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.OptimizersStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.OptimizersStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.OperationDurationStatistics Optimizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log")]
        public global::System.Collections.Generic.IList<global::Qdrant.TrackerTelemetry>? Log { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizerTelemetry" /> class.
        /// </summary>
        /// <param name="status">
        /// Current state of the collection
        /// </param>
        /// <param name="optimizations"></param>
        /// <param name="log"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptimizerTelemetry(
            global::Qdrant.OptimizersStatus status,
            global::Qdrant.OperationDurationStatistics optimizations,
            global::System.Collections.Generic.IList<global::Qdrant.TrackerTelemetry>? log)
        {
            this.Status = status;
            this.Optimizations = optimizations ?? throw new global::System.ArgumentNullException(nameof(optimizations));
            this.Log = log;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizerTelemetry" /> class.
        /// </summary>
        public OptimizerTelemetry()
        {
        }
    }
}