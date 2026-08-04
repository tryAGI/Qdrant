
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Requested memory placement of the index.<br/>
    /// The structural decision is carried by `index_type`; this field additionally distinguishes `cold` from `cached` for the mmap index variant.
    /// </summary>
    public sealed partial class SparseIndexConfigMemory
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}