
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClusterStatusTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_peers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfPeers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("term")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Term { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingOperations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::Qdrant.StateRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_voter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsVoter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peer_id")]
        public int? PeerId { get; set; }

        /// <summary>
        /// Information about current consensus thread status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensus_thread_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ConsensusThreadStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.ConsensusThreadStatus ConsensusThreadStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatusTelemetry" /> class.
        /// </summary>
        /// <param name="numberOfPeers"></param>
        /// <param name="term"></param>
        /// <param name="commit"></param>
        /// <param name="pendingOperations"></param>
        /// <param name="role"></param>
        /// <param name="isVoter"></param>
        /// <param name="peerId"></param>
        /// <param name="consensusThreadStatus">
        /// Information about current consensus thread status
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClusterStatusTelemetry(
            int numberOfPeers,
            int term,
            int commit,
            int pendingOperations,
            bool isVoter,
            global::Qdrant.ConsensusThreadStatus consensusThreadStatus,
            global::Qdrant.StateRole? role,
            int? peerId)
        {
            this.NumberOfPeers = numberOfPeers;
            this.Term = term;
            this.Commit = commit;
            this.PendingOperations = pendingOperations;
            this.IsVoter = isVoter;
            this.ConsensusThreadStatus = consensusThreadStatus;
            this.Role = role;
            this.PeerId = peerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterStatusTelemetry" /> class.
        /// </summary>
        public ClusterStatusTelemetry()
        {
        }
    }
}