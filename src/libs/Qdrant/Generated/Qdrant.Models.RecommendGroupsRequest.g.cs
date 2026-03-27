
#nullable enable

namespace Qdrant
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecommendGroupsRequest
    {
        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::Qdrant.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Look for vectors closest to those<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive")]
        public global::System.Collections.Generic.IList<global::Qdrant.RecommendExample>? Positive { get; set; }

        /// <summary>
        /// Try to avoid vectors like this<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative")]
        public global::System.Collections.Generic.IList<global::Qdrant.RecommendExample>? Negative { get; set; }

        /// <summary>
        /// How to use positive and negative examples to find the results<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        public global::Qdrant.RecommendStrategy? Strategy { get; set; }

        /// <summary>
        /// Look only for points which satisfies this conditions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Qdrant.Filter? Filter { get; set; }

        /// <summary>
        /// Additional search params
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::Qdrant.SearchParams? Params { get; set; }

        /// <summary>
        /// Select which payload to return with the response. Default is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_payload")]
        public global::Qdrant.WithPayloadInterface? WithPayload { get; set; }

        /// <summary>
        /// Options for specifying which vectors to include into response. Default is false.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_vector")]
        public global::Qdrant.WithVector? WithVector { get; set; }

        /// <summary>
        /// Define a minimal score threshold for the result. If defined, less similar results will not be returned. Score of the returned result might be higher or smaller than the threshold depending on the Distance function used. E.g. for cosine similarity only higher scores will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_threshold")]
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// Define which vector to use for recommendation, if not specified - try to use default vector<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("using")]
        public global::Qdrant.UsingVector? Using { get; set; }

        /// <summary>
        /// The location used to lookup vectors. If not specified - use current collection. Note: the other collection should have the same vector size as the current collection<br/>
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
        /// Maximum amount of points to return per group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GroupSize { get; set; }

        /// <summary>
        /// Maximum amount of groups to return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

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
        /// Initializes a new instance of the <see cref="RecommendGroupsRequest" /> class.
        /// </summary>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="positive">
        /// Look for vectors closest to those<br/>
        /// Default Value: []
        /// </param>
        /// <param name="negative">
        /// Try to avoid vectors like this<br/>
        /// Default Value: []
        /// </param>
        /// <param name="strategy">
        /// How to use positive and negative examples to find the results<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="filter">
        /// Look only for points which satisfies this conditions
        /// </param>
        /// <param name="params">
        /// Additional search params
        /// </param>
        /// <param name="withPayload">
        /// Select which payload to return with the response. Default is false.
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vectors to include into response. Default is false.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scoreThreshold">
        /// Define a minimal score threshold for the result. If defined, less similar results will not be returned. Score of the returned result might be higher or smaller than the threshold depending on the Distance function used. E.g. for cosine similarity only higher scores will be returned.
        /// </param>
        /// <param name="using">
        /// Define which vector to use for recommendation, if not specified - try to use default vector<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="lookupFrom">
        /// The location used to lookup vectors. If not specified - use current collection. Note: the other collection should have the same vector size as the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupBy">
        /// Payload field to group by, must be a string or number field. If the field contains more than 1 value, all values will be used for grouping. One point can be in multiple groups.
        /// </param>
        /// <param name="groupSize">
        /// Maximum amount of points to return per group
        /// </param>
        /// <param name="limit">
        /// Maximum amount of groups to return
        /// </param>
        /// <param name="withLookup">
        /// Look for points in another collection using the group ids
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendGroupsRequest(
            string groupBy,
            int groupSize,
            int limit,
            global::Qdrant.ShardKeySelector? shardKey,
            global::System.Collections.Generic.IList<global::Qdrant.RecommendExample>? positive,
            global::System.Collections.Generic.IList<global::Qdrant.RecommendExample>? negative,
            global::Qdrant.RecommendStrategy? strategy,
            global::Qdrant.Filter? filter,
            global::Qdrant.SearchParams? @params,
            global::Qdrant.WithPayloadInterface? withPayload,
            global::Qdrant.WithVector? withVector,
            float? scoreThreshold,
            global::Qdrant.UsingVector? @using,
            global::Qdrant.LookupLocation? lookupFrom,
            global::Qdrant.WithLookupInterface? withLookup)
        {
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.GroupSize = groupSize;
            this.Limit = limit;
            this.ShardKey = shardKey;
            this.Positive = positive;
            this.Negative = negative;
            this.Strategy = strategy;
            this.Filter = filter;
            this.Params = @params;
            this.WithPayload = withPayload;
            this.WithVector = withVector;
            this.ScoreThreshold = scoreThreshold;
            this.Using = @using;
            this.LookupFrom = lookupFrom;
            this.WithLookup = withLookup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendGroupsRequest" /> class.
        /// </summary>
        public RecommendGroupsRequest()
        {
        }
    }
}