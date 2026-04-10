#nullable enable

namespace Qdrant
{
    public partial interface IPointsClient
    {
        /// <summary>
        /// Update vectors<br/>
        /// Update specified named vectors on points, keep unspecified vectors intact.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="wait"></param>
        /// <param name="ordering">
        /// Defines write ordering guarantees for collection operations<br/>
        /// * `weak` - write operations may be reordered, works faster, default<br/>
        /// * `medium` - write operations go through dynamically selected leader, may be inconsistent for a short period of time in case of leader change<br/>
        /// * `strong` - Write operations go through the permanent leader, consistent, but may be unavailable if leader is down
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.UpdateVectorsResponse> UpdateVectorsAsync(
            string collectionName,

            global::Qdrant.UpdateVectors request,
            bool? wait = default,
            global::Qdrant.WriteOrdering? ordering = default,
            int? timeout = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update vectors<br/>
        /// Update specified named vectors on points, keep unspecified vectors intact.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="wait"></param>
        /// <param name="ordering">
        /// Defines write ordering guarantees for collection operations<br/>
        /// * `weak` - write operations may be reordered, works faster, default<br/>
        /// * `medium` - write operations go through dynamically selected leader, may be inconsistent for a short period of time in case of leader change<br/>
        /// * `strong` - Write operations go through the permanent leader, consistent, but may be unavailable if leader is down
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="points">
        /// Points with named vectors
        /// </param>
        /// <param name="shardKey"></param>
        /// <param name="updateFilter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.UpdateVectorsResponse> UpdateVectorsAsync(
            string collectionName,
            global::System.Collections.Generic.IList<global::Qdrant.PointVectors> points,
            bool? wait = default,
            global::Qdrant.WriteOrdering? ordering = default,
            int? timeout = default,
            global::Qdrant.ShardKeySelector? shardKey = default,
            global::Qdrant.Filter? updateFilter = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}