#nullable enable

namespace Qdrant
{
    public partial interface IPointsClient
    {
        /// <summary>
        /// Get point<br/>
        /// Retrieve full information of single point by id
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="id">
        /// Type, used for specifying point ID in user interface
        /// </param>
        /// <param name="consistency">
        /// Read consistency parameter<br/>
        /// Defines how many replicas should be queried to get the result<br/>
        /// * `N` - send N random request and return points, which present on all of them<br/>
        /// * `majority` - send N/2+1 random request and return points, which present on all of them<br/>
        /// * `quorum` - send requests to all nodes and return points which present on majority of them<br/>
        /// * `all` - send requests to all nodes and return points which present on all of them<br/>
        /// Default value is `Factor(1)`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.GetPointResponse> GetPointAsync(
            string collectionName,
            global::Qdrant.ExtendedPointId id,
            global::Qdrant.ReadConsistency? consistency = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}