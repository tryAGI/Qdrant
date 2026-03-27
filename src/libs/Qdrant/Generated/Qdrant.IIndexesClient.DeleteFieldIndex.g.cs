#nullable enable

namespace Qdrant
{
    public partial interface IIndexesClient
    {
        /// <summary>
        /// Delete index for field in collection<br/>
        /// Delete field index for collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="fieldName"></param>
        /// <param name="wait"></param>
        /// <param name="ordering">
        /// Defines write ordering guarantees for collection operations<br/>
        /// * `weak` - write operations may be reordered, works faster, default<br/>
        /// * `medium` - write operations go through dynamically selected leader, may be inconsistent for a short period of time in case of leader change<br/>
        /// * `strong` - Write operations go through the permanent leader, consistent, but may be unavailable if leader is down
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.DeleteFieldIndexResponse> DeleteFieldIndexAsync(
            string collectionName,
            string fieldName,
            bool? wait = default,
            global::Qdrant.WriteOrdering? ordering = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}