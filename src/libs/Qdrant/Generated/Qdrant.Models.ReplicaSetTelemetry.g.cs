
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplicaSetTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::Qdrant.ShardKey? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("local")]
        public global::Qdrant.LocalShardTelemetry? Local { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Qdrant.RemoteShardTelemetry> Remote { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicate_states")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Qdrant.ReplicaState> ReplicateStates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_snapshot")]
        public global::Qdrant.PartialSnapshotTelemetry? PartialSnapshot { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicaSetTelemetry" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="remote"></param>
        /// <param name="replicateStates"></param>
        /// <param name="key"></param>
        /// <param name="local"></param>
        /// <param name="partialSnapshot"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicaSetTelemetry(
            int id,
            global::System.Collections.Generic.IList<global::Qdrant.RemoteShardTelemetry> remote,
            global::System.Collections.Generic.Dictionary<string, global::Qdrant.ReplicaState> replicateStates,
            global::Qdrant.ShardKey? key,
            global::Qdrant.LocalShardTelemetry? local,
            global::Qdrant.PartialSnapshotTelemetry? partialSnapshot)
        {
            this.Id = id;
            this.Key = key;
            this.Local = local;
            this.Remote = remote ?? throw new global::System.ArgumentNullException(nameof(remote));
            this.ReplicateStates = replicateStates ?? throw new global::System.ArgumentNullException(nameof(replicateStates));
            this.PartialSnapshot = partialSnapshot;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicaSetTelemetry" /> class.
        /// </summary>
        public ReplicaSetTelemetry()
        {
        }
    }
}