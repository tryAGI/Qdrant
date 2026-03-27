/*
order: 30
title: Snapshots
slug: snapshots

Create, list, and delete snapshots for a Qdrant collection.
*/

namespace Qdrant.IntegrationTests;

public partial class Tests
{
    //// Snapshots provide a way to back up and restore collection data.
    //// This example demonstrates creating, listing, and deleting snapshots.

    [TestMethod]
    public async Task Example_Snapshots()
    {
        var client = Client;
        var collectionName = $"test_snapshots_{Guid.NewGuid():N}";

        //// Create a collection to snapshot.

        await client.Collections.CreateCollectionAsync(
            collectionName: collectionName,
            vectors: new VectorParams
            {
                Size = 4,
                Distance = Distance.Cosine,
            });

        //// Create a snapshot of the collection.

        var createResponse = await client.Snapshots.CreateSnapshotAsync(
            collectionName: collectionName,
            wait: true);

        createResponse.Should().NotBeNull();
        createResponse.Status.Should().Be("ok");
        createResponse.Result.Should().NotBeNull();
        createResponse.Result!.Name.Should().NotBeNullOrEmpty();

        var snapshotName = createResponse.Result.Name;
        Console.WriteLine($"Created snapshot: {snapshotName}");

        //// List all snapshots for the collection.

        var listResponse = await client.Snapshots.ListSnapshotsAsync(
            collectionName: collectionName);

        listResponse.Should().NotBeNull();
        listResponse.Status.Should().Be("ok");
        listResponse.Result.Should().NotBeNull();
        listResponse.Result.Should().HaveCountGreaterThanOrEqualTo(1);
        listResponse.Result.Should().Contain(s => s.Name == snapshotName);

        Console.WriteLine($"Found {listResponse.Result!.Count} snapshot(s).");

        //// Delete the snapshot.

        var deleteResponse = await client.Snapshots.DeleteSnapshotAsync(
            collectionName: collectionName,
            snapshotName: snapshotName,
            wait: true);

        deleteResponse.Should().NotBeNull();
        deleteResponse.Status.Should().Be("ok");

        Console.WriteLine($"Deleted snapshot: {snapshotName}");

        //// Verify the snapshot was deleted.

        var listAfterDelete = await client.Snapshots.ListSnapshotsAsync(
            collectionName: collectionName);

        listAfterDelete.Result.Should().NotContain(s => s.Name == snapshotName);

        //// Cleanup: delete the collection.

        await client.Collections.DeleteCollectionAsync(
            collectionName: collectionName);
    }
}
