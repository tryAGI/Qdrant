#nullable enable

namespace Qdrant
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Clear issues<br/>
        /// Removes all issues reported so far
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Qdrant.ClearIssuesResponse> ClearIssuesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}