#nullable enable

namespace Qdrant
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Query points in batch<br/>
        /// Universally query points in batch. This endpoint covers all capabilities of search, recommend, discover, filters. But also enables hybrid and multi-stage queries.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.QueryBatchPointsResponse> QueryBatchPointsAsync(
            string collectionName,

            global::Qdrant.QueryRequestBatch request,
            global::Qdrant.ReadConsistency? consistency = default,
            int? timeout = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query points in batch<br/>
        /// Universally query points in batch. This endpoint covers all capabilities of search, recommend, discover, filters. But also enables hybrid and multi-stage queries.
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
        /// <param name="searches"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.QueryBatchPointsResponse> QueryBatchPointsAsync(
            string collectionName,
            global::System.Collections.Generic.IList<global::Qdrant.QueryRequest> searches,
            global::Qdrant.ReadConsistency? consistency = default,
            int? timeout = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}