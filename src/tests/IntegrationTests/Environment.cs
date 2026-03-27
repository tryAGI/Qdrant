using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace Qdrant.IntegrationTests;

public sealed class Environment : IAsyncDisposable
{
    private const string QdrantImage = "qdrant/qdrant:latest";
    private const ushort QdrantPort = 6333;
    private static readonly TimeSpan StartupTimeout = TimeSpan.FromMinutes(2);

    public IContainer? Container { get; init; }
    public required QdrantClient Client { get; init; }

    public async ValueTask DisposeAsync()
    {
        Client.Dispose();
        if (Container != null)
        {
            await Container.DisposeAsync();
        }
    }

    public static async Task<Environment> PrepareAsync(EnvironmentType? environmentType = null)
    {
        environmentType ??= InferEnvironment();
        switch (environmentType)
        {
            case EnvironmentType.Local:
            {
                var client = new QdrantClient(
                    baseUri: new Uri($"http://127.0.0.1:{QdrantPort}"));

                return new Environment
                {
                    Client = client,
                };
            }
            case EnvironmentType.Container:
            {
                var container = new ContainerBuilder(QdrantImage)
                    .WithPortBinding(QdrantPort, assignRandomHostPort: true)
                    .WithWaitStrategy(
                        Wait.ForUnixContainer()
                            .UntilHttpRequestIsSucceeded(request => request
                                .ForPath("/healthz")
                                .ForPort(QdrantPort)))
                    .Build();

                using var cts = new CancellationTokenSource(StartupTimeout);
                await container.StartAsync(cts.Token);

                var client = new QdrantClient(
                    baseUri: new UriBuilder(
                        Uri.UriSchemeHttp,
                        container.Hostname,
                        container.GetMappedPublicPort(QdrantPort)).Uri);

                return new Environment
                {
                    Container = container,
                    Client = client,
                };
            }
            default:
                throw new ArgumentOutOfRangeException(nameof(environmentType), environmentType, null);
        }
    }

    private static EnvironmentType InferEnvironment()
    {
#if DEBUG
        return EnvironmentType.Local;
#else
        return EnvironmentType.Container;
#endif
    }
}

public enum EnvironmentType
{
    Local,
    Container,
}
