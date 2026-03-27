
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsensusThreadStatusVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensus_thread_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ConsensusThreadStatusVariant1ConsensusThreadStatusJsonConverter))]
        public global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus ConsensusThreadStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_update")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusThreadStatusVariant1" /> class.
        /// </summary>
        /// <param name="consensusThreadStatus"></param>
        /// <param name="lastUpdate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsensusThreadStatusVariant1(
            global::System.DateTime lastUpdate,
            global::Qdrant.ConsensusThreadStatusVariant1ConsensusThreadStatus consensusThreadStatus)
        {
            this.LastUpdate = lastUpdate;
            this.ConsensusThreadStatus = consensusThreadStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusThreadStatusVariant1" /> class.
        /// </summary>
        public ConsensusThreadStatusVariant1()
        {
        }
    }
}