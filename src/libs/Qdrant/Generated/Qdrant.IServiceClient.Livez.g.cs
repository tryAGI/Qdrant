#nullable enable

namespace Qdrant
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Kubernetes livez endpoint<br/>
        /// An endpoint for health checking used in Kubernetes.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Qdrant.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LivezAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}