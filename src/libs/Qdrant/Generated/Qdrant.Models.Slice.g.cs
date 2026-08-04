
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// One of `total` disjoint deterministic slices of the id space.<br/>
    /// A point belongs to the slice iff `hash(id) % total == index`, where `hash` is SipHash-2-4 with a zero key over the canonical id bytes: 8 little-endian bytes for numeric ids, the 16 RFC 4122 bytes for UUIDs. For a fixed `total`, slices `0..total` are disjoint and together cover all points; membership is uniform regardless of the id scheme and stable across queries, segments, platforms and Qdrant versions.<br/>
    /// Slices with different `total` values are correlated (same hash, no salt): e.g. slice `0` of `total: 4` is a strict subset of slice `0` of `total: 2`. This keeps a smaller sample contained in a larger one.
    /// </summary>
    public sealed partial class Slice
    {
        /// <summary>
        /// Total number of disjoint slices the id space is split into
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Which slice to select, must be in `0..total`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Slice" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of disjoint slices the id space is split into
        /// </param>
        /// <param name="index">
        /// Which slice to select, must be in `0..total`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Slice(
            int total,
            int index)
        {
            this.Total = total;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Slice" /> class.
        /// </summary>
        public Slice()
        {
        }

    }
}