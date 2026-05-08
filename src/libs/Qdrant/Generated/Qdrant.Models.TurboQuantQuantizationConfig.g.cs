
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TurboQuantQuantizationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("always_ram")]
        public bool? AlwaysRam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bits")]
        public global::Qdrant.TurboQuantBitSize? Bits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurboQuantQuantizationConfig" /> class.
        /// </summary>
        /// <param name="alwaysRam"></param>
        /// <param name="bits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurboQuantQuantizationConfig(
            bool? alwaysRam,
            global::Qdrant.TurboQuantBitSize? bits)
        {
            this.AlwaysRam = alwaysRam;
            this.Bits = bits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurboQuantQuantizationConfig" /> class.
        /// </summary>
        public TurboQuantQuantizationConfig()
        {
        }
    }
}