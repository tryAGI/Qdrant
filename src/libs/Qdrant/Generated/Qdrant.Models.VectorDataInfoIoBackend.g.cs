
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Universal I/O backend that this vector storage reads files with. Absent if vector storage does not support configurable backends or only supports a single backend type.
    /// </summary>
    public sealed partial class VectorDataInfoIoBackend
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}