
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryGroupsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::Qdrant.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Sub-requests to perform first. If present, the query will be performed on the results of the prefetch(es).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefetch")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Qdrant.JsonConverters.AnyOfJsonConverter<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>, object>))]
        public global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>, object>? Prefetch { get; set; }

        /// <summary>
        /// Query to perform. If missing without prefetches, returns points ordered by their IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public global::Qdrant.QueryInterface? Query { get; set; }

        /// <summary>
        /// Define which vector name to use for querying. If missing, the default vector is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("using")]
        public string? Using { get; set; }

        /// <summary>
        /// Filter conditions - return only those points that satisfy the specified conditions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Qdrant.Filter? Filter { get; set; }

        /// <summary>
        /// Search params for when there is no prefetch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::Qdrant.SearchParams? Params { get; set; }

        /// <summary>
        /// Return points with scores better than this threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_threshold")]
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// Options for specifying which vectors to include into the response. Default is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_vector")]
        public global::Qdrant.WithVector? WithVector { get; set; }

        /// <summary>
        /// Options for specifying which payload to include or not. Default is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_payload")]
        public global::Qdrant.WithPayloadInterface? WithPayload { get; set; }

        /// <summary>
        /// The location to use for IDs lookup, if not specified - use the current collection and the 'using' vector Note: the other collection vectors should have the same vector size as the 'using' vector in the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lookup_from")]
        public global::Qdrant.LookupLocation? LookupFrom { get; set; }

        /// <summary>
        /// Payload field to group by, must be a string or number field. If the field contains more than 1 value, all values will be used for grouping. One point can be in multiple groups.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupBy { get; set; }

        /// <summary>
        /// Maximum amount of points to return per group. Default is 3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_size")]
        public int? GroupSize { get; set; }

        /// <summary>
        /// Maximum amount of groups to return. Default is 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Look for points in another collection using the group ids
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_lookup")]
        public global::Qdrant.WithLookupInterface? WithLookup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryGroupsRequest" /> class.
        /// </summary>
        /// <param name="shardKey"></param>
        /// <param name="prefetch">
        /// Sub-requests to perform first. If present, the query will be performed on the results of the prefetch(es).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="query">
        /// Query to perform. If missing without prefetches, returns points ordered by their IDs.
        /// </param>
        /// <param name="using">
        /// Define which vector name to use for querying. If missing, the default vector is used.
        /// </param>
        /// <param name="filter">
        /// Filter conditions - return only those points that satisfy the specified conditions.
        /// </param>
        /// <param name="params">
        /// Search params for when there is no prefetch
        /// </param>
        /// <param name="scoreThreshold">
        /// Return points with scores better than this threshold.
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vectors to include into the response. Default is false.
        /// </param>
        /// <param name="withPayload">
        /// Options for specifying which payload to include or not. Default is false.
        /// </param>
        /// <param name="lookupFrom">
        /// The location to use for IDs lookup, if not specified - use the current collection and the 'using' vector Note: the other collection vectors should have the same vector size as the 'using' vector in the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupBy">
        /// Payload field to group by, must be a string or number field. If the field contains more than 1 value, all values will be used for grouping. One point can be in multiple groups.
        /// </param>
        /// <param name="groupSize">
        /// Maximum amount of points to return per group. Default is 3.
        /// </param>
        /// <param name="limit">
        /// Maximum amount of groups to return. Default is 10.
        /// </param>
        /// <param name="withLookup">
        /// Look for points in another collection using the group ids
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryGroupsRequest(
            string groupBy,
            global::Qdrant.ShardKeySelector? shardKey,
            global::Qdrant.AnyOf<global::Qdrant.Prefetch2, global::System.Collections.Generic.IList<global::Qdrant.Prefetch2>, object>? prefetch,
            global::Qdrant.QueryInterface? query,
            string? @using,
            global::Qdrant.Filter? filter,
            global::Qdrant.SearchParams? @params,
            float? scoreThreshold,
            global::Qdrant.WithVector? withVector,
            global::Qdrant.WithPayloadInterface? withPayload,
            global::Qdrant.LookupLocation? lookupFrom,
            int? groupSize,
            int? limit,
            global::Qdrant.WithLookupInterface? withLookup)
        {
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.ShardKey = shardKey;
            this.Prefetch = prefetch;
            this.Query = query;
            this.Using = @using;
            this.Filter = filter;
            this.Params = @params;
            this.ScoreThreshold = scoreThreshold;
            this.WithVector = withVector;
            this.WithPayload = withPayload;
            this.LookupFrom = lookupFrom;
            this.GroupSize = groupSize;
            this.Limit = limit;
            this.WithLookup = withLookup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryGroupsRequest" /> class.
        /// </summary>
        public QueryGroupsRequest()
        {
        }
    }
}