
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsensusThreadStatusVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consensus_thread_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.ConsensusThreadStatusVariant3ConsensusThreadStatusJsonConverter))]
        public global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus ConsensusThreadStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("err")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Err { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusThreadStatusVariant3" /> class.
        /// </summary>
        /// <param name="err"></param>
        /// <param name="consensusThreadStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsensusThreadStatusVariant3(
            string err,
            global::Qdrant.ConsensusThreadStatusVariant3ConsensusThreadStatus consensusThreadStatus)
        {
            this.ConsensusThreadStatus = consensusThreadStatus;
            this.Err = err ?? throw new global::System.ArgumentNullException(nameof(err));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusThreadStatusVariant3" /> class.
        /// </summary>
        public ConsensusThreadStatusVariant3()
        {
        }
    }
}