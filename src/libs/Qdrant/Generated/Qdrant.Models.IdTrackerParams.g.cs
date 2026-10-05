
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Params of the point id tracker
    /// </summary>
    public sealed partial class IdTrackerParams
    {
        /// <summary>
        /// Memory placement of the point id mapping in indexed segments: `cold` keeps it on disk and reads it on demand, `cached` keeps it on disk but primes the page cache with it on load, `pinned` keeps it in RAM. Default: `pinned`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public global::Qdrant.Memory? Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdTrackerParams" /> class.
        /// </summary>
        /// <param name="memory">
        /// Memory placement of the point id mapping in indexed segments: `cold` keeps it on disk and reads it on demand, `cached` keeps it on disk but primes the page cache with it on load, `pinned` keeps it in RAM. Default: `pinned`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdTrackerParams(
            global::Qdrant.Memory? memory)
        {
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdTrackerParams" /> class.
        /// </summary>
        public IdTrackerParams()
        {
        }

    }
}