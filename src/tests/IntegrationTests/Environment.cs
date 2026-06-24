using System.Diagnostics;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace Qdrant.IntegrationTests;

public sealed class Environment : IAsyncDisposable
{
    private const string QdrantImage = "qdrant/qdrant:latest";
    private const ushort QdrantPort = 6333;
    private const string DefaultApiKey = "test-api-key";
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
                    apiKey: GetApiKey(),
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
                    apiKey: GetApiKey(),
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

    private static string GetApiKey()
    {
        return System.Environment.GetEnvironmentVariable("QDRANT_API_KEY") is { Length: > 0 } apiKey
            ? apiKey
            : DefaultApiKey;
    }

    private static EnvironmentType InferEnvironment()
    {
        if (System.Environment.GetEnvironmentVariable("QDRANT_TEST_ENVIRONMENT") is { Length: > 0 } environmentValue &&
            Enum.TryParse<EnvironmentType>(environmentValue, ignoreCase: true, out var environmentType))
        {
            return environmentType;
        }

        if (IsDockerAvailable())
        {
            return EnvironmentType.Container;
        }

#if DEBUG
        return EnvironmentType.Local;
#else
        return EnvironmentType.Container;
#endif
    }

    private static bool IsDockerAvailable()
    {
        try
        {
            using var process = Process.Start(new ProcessStartInfo
            {
                FileName = "docker",
                ArgumentList = { "info", "--format", "{{.ServerVersion}}" },
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            });

            return process is not null &&
                   process.WaitForExit(milliseconds: 5000) &&
                   process.ExitCode == 0;
        }
        catch
        {
            return false;
        }
    }
}

public enum EnvironmentType
{
    Local,
    Container,
}
