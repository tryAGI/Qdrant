#nullable enable

namespace Qdrant
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Delete storage snapshot<br/>
        /// Delete snapshot of the whole storage
        /// </summary>
        /// <param name="snapshotName"></param>
        /// <param name="wait"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.DeleteFullSnapshotResponse> DeleteFullSnapshotAsync(
            string snapshotName,
            bool? wait = default,
            global::Qdrant.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}