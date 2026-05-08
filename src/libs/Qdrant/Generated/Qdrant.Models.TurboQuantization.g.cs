
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TurboQuantization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turbo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.TurboQuantQuantizationConfig Turbo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurboQuantization" /> class.
        /// </summary>
        /// <param name="turbo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurboQuantization(
            global::Qdrant.TurboQuantQuantizationConfig turbo)
        {
            this.Turbo = turbo ?? throw new global::System.ArgumentNullException(nameof(turbo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurboQuantization" /> class.
        /// </summary>
        public TurboQuantization()
        {
        }
    }
}