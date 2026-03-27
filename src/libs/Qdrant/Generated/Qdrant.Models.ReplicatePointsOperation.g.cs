
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplicatePointsOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicate_points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.ReplicatePoints ReplicatePoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicatePointsOperation" /> class.
        /// </summary>
        /// <param name="replicatePoints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicatePointsOperation(
            global::Qdrant.ReplicatePoints replicatePoints)
        {
            this.ReplicatePoints = replicatePoints ?? throw new global::System.ArgumentNullException(nameof(replicatePoints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicatePointsOperation" /> class.
        /// </summary>
        public ReplicatePointsOperation()
        {
        }
    }
}