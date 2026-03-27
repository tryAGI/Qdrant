
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FacetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::Qdrant.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Payload key to use for faceting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Max number of hits to return. Default is 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Filter conditions - only consider points that satisfy these conditions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Qdrant.Filter? Filter { get; set; }

        /// <summary>
        /// Whether to do a more expensive exact count for each of the values in the facet. Default is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exact")]
        public bool? Exact { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetRequest" /> class.
        /// </summary>
        /// <param name="shardKey"></param>
        /// <param name="key">
        /// Payload key to use for faceting.
        /// </param>
        /// <param name="limit">
        /// Max number of hits to return. Default is 10.
        /// </param>
        /// <param name="filter">
        /// Filter conditions - only consider points that satisfy these conditions.
        /// </param>
        /// <param name="exact">
        /// Whether to do a more expensive exact count for each of the values in the facet. Default is false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FacetRequest(
            string key,
            global::Qdrant.ShardKeySelector? shardKey,
            int? limit,
            global::Qdrant.Filter? filter,
            bool? exact)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.ShardKey = shardKey;
            this.Limit = limit;
            this.Filter = filter;
            this.Exact = exact;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetRequest" /> class.
        /// </summary>
        public FacetRequest()
        {
        }
    }
}