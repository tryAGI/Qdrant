
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Params of the payload storage
    /// </summary>
    public sealed partial class PayloadStorageParams
    {
        /// <summary>
        /// Memory placement of the payload storage. Overrides the deprecated `on_disk_payload` flag if both are set. `pinned` is not supported for payload storage. Default: `cold` (`cached` if `on_disk_payload` is set to false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public global::Qdrant.Memory? Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadStorageParams" /> class.
        /// </summary>
        /// <param name="memory">
        /// Memory placement of the payload storage. Overrides the deprecated `on_disk_payload` flag if both are set. `pinned` is not supported for payload storage. Default: `cold` (`cached` if `on_disk_payload` is set to false).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PayloadStorageParams(
            global::Qdrant.Memory? memory)
        {
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadStorageParams" /> class.
        /// </summary>
        public PayloadStorageParams()
        {
        }

    }
}