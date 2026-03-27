/*
order: 10
title: Collections
slug: collections

Manage Qdrant collections -- create, list, inspect, and delete.
*/

namespace Qdrant.IntegrationTests;

public partial class Tests
{
    //// Create a collection with Cosine distance metric, list all collections
    //// to verify it exists, get detailed collection info, and then delete it.

    [TestMethod]
    public async Task Example_Collections()
    {
        var client = Client;
        var collectionName = $"test_collection_{Guid.NewGuid():N}";

        //// Create a new collection with 4-dimensional vectors using Cosine distance.

        var createResponse = await client.Collections.CreateCollectionAsync(
            collectionName: collectionName,
            vectors: new VectorParams
            {
                Size = 4,
                Distance = Distance.Cosine,
            });

        createResponse.Should().NotBeNull();
        createResponse.Status.Should().Be("ok");
        createResponse.Result.Should().Be(true);

        Console.WriteLine($"Collection '{collectionName}' created successfully.");

        //// List all collections and verify the new one exists.

        var listResponse = await client.Collections.GetCollectionsAsync();

        listResponse.Should().NotBeNull();
        listResponse.Status.Should().Be("ok");
        listResponse.Result.Should().NotBeNull();
        listResponse.Result!.Collections
            .Should().Contain(c => c.Name == collectionName);

        Console.WriteLine($"Found {listResponse.Result.Collections.Count} collection(s).");

        //// Check that the collection exists using the dedicated endpoint.

        var existsResponse = await client.Collections.CollectionExistsAsync(
            collectionName: collectionName);

        existsResponse.Should().NotBeNull();
        existsResponse.Result.Should().NotBeNull();
        existsResponse.Result!.Exists.Should().Be(true);

        //// Get detailed information about the collection.

        var getResponse = await client.Collections.GetCollectionAsync(
            collectionName: collectionName);

        getResponse.Should().NotBeNull();
        getResponse.Status.Should().Be("ok");
        getResponse.Result.Should().NotBeNull();

        Console.WriteLine($"Collection status: {getResponse.Result!.Status}");
        Console.WriteLine($"Points count: {getResponse.Result.PointsCount}");

        //// Delete the collection.

        var deleteResponse = await client.Collections.DeleteCollectionAsync(
            collectionName: collectionName);

        deleteResponse.Should().NotBeNull();
        deleteResponse.Status.Should().Be("ok");
        deleteResponse.Result.Should().Be(true);

        Console.WriteLine($"Collection '{collectionName}' deleted.");

        //// Verify the collection no longer exists.

        var existsAfterDelete = await client.Collections.CollectionExistsAsync(
            collectionName: collectionName);

        existsAfterDelete.Result!.Exists.Should().Be(false);
    }
}
