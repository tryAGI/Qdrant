namespace Qdrant.IntegrationTests;

/// <summary>
/// Calls that exist to prove the generated models can read what the server actually sends.
/// </summary>
/// <remarks>
/// The generated deserializers enforce <c>required</c>, so a field the server omits turns a
/// successful HTTP 200 into a <c>JsonException</c>. This spec enforces 257 required fields across
/// 108 response schemas - more than any other container-backed SDK here - and the four existing
/// examples touch four of 72 operations, so "the tests are green" said very little about the rest.
///
/// `GET /telemetry` is the valuable one: a single call whose response carries the schemas with the
/// deepest required lists (`SegmentInfo` at 13 fields, `VectorIndexSearchesTelemetry` at 9,
/// `HardwareUsage` at 7, and the cluster, audit, memory and tracker trees behind them), none of
/// which any response names directly. Everything here runs against the Testcontainers instance, so
/// it costs nothing and needs no key.
/// </remarks>
public partial class Tests
{
    [TestMethod]
    public async Task Telemetry_DeserializesTheWholeTree()
    {
        // detailsLevel asks the server for the nested trees rather than a summary, which is the
        // point: the deep required lists only appear once it fills them in.
        var telemetry = await Client.Service.TelemetryAsync(detailsLevel: 10);

        telemetry.Should().NotBeNull();
        telemetry.Result.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Telemetry_AnonymizedAndPerCollection()
    {
        var telemetry = await Client.Service.TelemetryAsync(
            anonymize: true,
            perCollection: true,
            detailsLevel: 10);

        telemetry.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Root_ReportsVersionInfo()
    {
        var version = await Client.Service.RootAsync();

        version.Should().NotBeNull();
        version.Version.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task ClusterStatus_Deserializes()
    {
        var cluster = await Client.Distributed.ClusterStatusAsync();

        cluster.Should().NotBeNull();
    }

    [TestMethod]
    public async Task HealthEndpoints_Respond()
    {
        await Client.Service.HealthzAsync();
        await Client.Service.LivezAsync();
        await Client.Service.ReadyzAsync();
    }

    [TestMethod]
    public async Task CollectionsAliases_Deserializes()
    {
        var aliases = await Client.Aliases.GetCollectionsAliasesAsync();

        aliases.Should().NotBeNull();
    }

    /// <summary>
    /// `CollectionInfo` and `CollectionClusterInfo` enforce five required fields each and both hang
    /// off a collection name, so this one needs a fixture - created here and removed in `finally`.
    /// </summary>
    [TestMethod]
    public async Task CollectionScopedResponses_Deserialize()
    {
        var collectionName = $"tryagi-probe-{Guid.NewGuid():N}";

        _ = await Client.Collections.CreateCollectionAsync(
            collectionName: collectionName,
            vectors: new VectorParams
            {
                Size = 4,
                Distance = Distance.Cosine,
            });

        try
        {
            var exists = await Client.Collections.CollectionExistsAsync(collectionName: collectionName);
            exists.Result?.Exists.Should().BeTrue();

            var info = await Client.Collections.GetCollectionAsync(collectionName: collectionName);
            info.Result.Should().NotBeNull();

            var clusterInfo = await Client.Distributed.CollectionClusterInfoAsync(collectionName: collectionName);
            clusterInfo.Result.Should().NotBeNull();

            var aliases = await Client.Aliases.GetCollectionAliasesAsync(collectionName: collectionName);
            aliases.Should().NotBeNull();
        }
        finally
        {
            // Swallow only the cleanup's own failure: the verdict belongs to the assertions above.
            try
            {
                _ = await Client.Collections.DeleteCollectionAsync(collectionName: collectionName);
            }
            catch (ApiException)
            {
            }
        }
    }
}
