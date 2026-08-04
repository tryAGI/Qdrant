
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Memory placement of quantized vectors. Overrides the deprecated `always_ram` flag if both are set. Default: follow the memory placement of the original vector storage.
    /// </summary>
    public sealed partial class TurboQuantQuantizationConfigMemory
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}