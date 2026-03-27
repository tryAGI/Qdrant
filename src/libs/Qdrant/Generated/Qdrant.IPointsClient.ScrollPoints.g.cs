#nullable enable

namespace Qdrant
{
    public partial interface IPointsClient
    {
        /// <summary>
        /// Scroll points<br/>
        /// Scroll request - paginate over all points which matches given filtering condition
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="consistency">
        /// Read consistency parameter<br/>
        /// Defines how many replicas should be queried to get the result<br/>
        /// * `N` - send N random request and return points, which present on all of them<br/>
        /// * `majority` - send N/2+1 random request and return points, which present on all of them<br/>
        /// * `quorum` - send requests to all nodes and return points which present on majority of them<br/>
        /// * `all` - send requests to all nodes and return points which present on all of them<br/>
        /// Default value is `Factor(1)`
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.ScrollPointsResponse> ScrollPointsAsync(
            string collectionName,

            global::Qdrant.ScrollRequest request,
            global::Qdrant.ReadConsistency? consistency = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Scroll points<br/>
        /// Scroll request - paginate over all points which matches given filtering condition
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="consistency">
        /// Read consistency parameter<br/>
        /// Defines how many replicas should be queried to get the result<br/>
        /// * `N` - send N random request and return points, which present on all of them<br/>
        /// * `majority` - send N/2+1 random request and return points, which present on all of them<br/>
        /// * `quorum` - send requests to all nodes and return points which present on majority of them<br/>
        /// * `all` - send requests to all nodes and return points which present on all of them<br/>
        /// Default value is `Factor(1)`
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="offset">
        /// Start ID to read points from.
        /// </param>
        /// <param name="limit">
        /// Page size. Default: 10
        /// </param>
        /// <param name="filter">
        /// Look only for points which satisfies this conditions. If not provided - all points.
        /// </param>
        /// <param name="withPayload">
        /// Select which payload to return with the response. Default is true.
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vector to include
        /// </param>
        /// <param name="orderBy">
        /// Order the records by a payload field.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.ScrollPointsResponse> ScrollPointsAsync(
            string collectionName,
            global::Qdrant.ReadConsistency? consistency = default,
            int? timeout = default,
            global::Qdrant.ShardKeySelector? shardKey = default,
            global::Qdrant.ExtendedPointId? offset = default,
            int? limit = default,
            global::Qdrant.Filter? filter = default,
            global::Qdrant.WithPayloadInterface? withPayload = default,
            global::Qdrant.WithVector? withVector = default,
            global::Qdrant.OrderByInterface? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}