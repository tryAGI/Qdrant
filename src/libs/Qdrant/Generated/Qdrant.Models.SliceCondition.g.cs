
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// Select points that fall into one of `total` disjoint deterministic slices of the id space, for parallel scans and reproducible sampling.
    /// </summary>
    public sealed partial class SliceCondition
    {
        /// <summary>
        /// One of `total` disjoint deterministic slices of the id space.<br/>
        /// A point belongs to the slice iff `hash(id) % total == index`, where `hash` is SipHash-2-4 with a zero key over the canonical id bytes: 8 little-endian bytes for numeric ids, the 16 RFC 4122 bytes for UUIDs. For a fixed `total`, slices `0..total` are disjoint and together cover all points; membership is uniform regardless of the id scheme and stable across queries, segments, platforms and Qdrant versions.<br/>
        /// Slices with different `total` values are correlated (same hash, no salt): e.g. slice `0` of `total: 4` is a strict subset of slice `0` of `total: 2`. This keeps a smaller sample contained in a larger one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Qdrant.Slice Slice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SliceCondition" /> class.
        /// </summary>
        /// <param name="slice">
        /// One of `total` disjoint deterministic slices of the id space.<br/>
        /// A point belongs to the slice iff `hash(id) % total == index`, where `hash` is SipHash-2-4 with a zero key over the canonical id bytes: 8 little-endian bytes for numeric ids, the 16 RFC 4122 bytes for UUIDs. For a fixed `total`, slices `0..total` are disjoint and together cover all points; membership is uniform regardless of the id scheme and stable across queries, segments, platforms and Qdrant versions.<br/>
        /// Slices with different `total` values are correlated (same hash, no salt): e.g. slice `0` of `total: 4` is a strict subset of slice `0` of `total: 2`. This keeps a smaller sample contained in a larger one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SliceCondition(
            global::Qdrant.Slice slice)
        {
            this.Slice = slice ?? throw new global::System.ArgumentNullException(nameof(slice));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SliceCondition" /> class.
        /// </summary>
        public SliceCondition()
        {
        }

    }
}