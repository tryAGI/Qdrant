#nullable enable

namespace Qdrant
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Download storage snapshot<br/>
        /// Download specified snapshot of the whole storage as a file
        /// </summary>
        /// <param name="snapshotName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetFullSnapshotAsync(
            string snapshotName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}