#nullable enable

namespace Qdrant
{
    public partial interface IPointsClient
    {
        /// <summary>
        /// Delete vectors<br/>
        /// Delete named vectors from the given points.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.DeleteVectorsResponse> DeleteVectorsAsync(
            string collectionName,

            global::Qdrant.DeleteVectors request,
            bool? wait = default,
            global::Qdrant.WriteOrdering? ordering = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete vectors<br/>
        /// Delete named vectors from the given points.
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
        /// Deletes values from each point in this list
        /// </param>
        /// <param name="filter">
        /// Deletes values from points that satisfy this filter condition
        /// </param>
        /// <param name="vector">
        /// Vector names
        /// </param>
        /// <param name="shardKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.DeleteVectorsResponse> DeleteVectorsAsync(
            string collectionName,
            global::System.Collections.Generic.IList<string> vector,
            bool? wait = default,
            global::Qdrant.WriteOrdering? ordering = default,
            int? timeout = default,
            global::System.Collections.Generic.IList<global::Qdrant.ExtendedPointId>? points = default,
            global::Qdrant.Filter? filter = default,
            global::Qdrant.ShardKeySelector? shardKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}