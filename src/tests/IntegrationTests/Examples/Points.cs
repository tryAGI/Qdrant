/*
order: 20
title: Points
slug: points

Insert, retrieve, search, and delete points (vectors with payload) in a Qdrant collection.
*/

namespace Qdrant.IntegrationTests;

public partial class Tests
{
    //// Create a collection, upsert points with vectors and payload,
    //// retrieve a specific point, search for nearest neighbors,
    //// and delete points.

    [TestMethod]
    public async Task Example_Points()
    {
        var client = Client;
        var collectionName = $"test_points_{Guid.NewGuid():N}";

        //// Create a collection with 4-dimensional vectors using Dot product distance.

        await client.Collections.CreateCollectionAsync(
            collectionName: collectionName,
            vectors: new VectorParams
            {
                Size = 4,
                Distance = Distance.Dot,
            });

        //// Upsert points with vectors and payload data.

        var upsertResponse = await client.Points.UpsertPointsAsync(
            collectionName: collectionName,
            wait: true,
            request: new PointsList
            {
                Points =
                [
                    new PointStruct
                    {
                        Id = 1,
                        Vector = new VectorStruct { Value1 = new[] { 0.05f, 0.61f, 0.76f, 0.74f } },
                        Payload = new { city = "Berlin" },
                    },
                    new PointStruct
                    {
                        Id = 2,
                        Vector = new VectorStruct { Value1 = new[] { 0.19f, 0.81f, 0.75f, 0.11f } },
                        Payload = new { city = "London" },
                    },
                    new PointStruct
                    {
                        Id = 3,
                        Vector = new VectorStruct { Value1 = new[] { 0.36f, 0.55f, 0.47f, 0.94f } },
                        Payload = new { city = "Moscow" },
                    },
                    new PointStruct
                    {
                        Id = 4,
                        Vector = new VectorStruct { Value1 = new[] { 0.18f, 0.01f, 0.85f, 0.80f } },
                        Payload = new { city = "New York" },
                    },
                    new PointStruct
                    {
                        Id = 5,
                        Vector = new VectorStruct { Value1 = new[] { 0.24f, 0.18f, 0.22f, 0.44f } },
                        Payload = new { city = "Tokyo" },
                    },
                ],
            });

        upsertResponse.Should().NotBeNull();
        upsertResponse.Status.Should().Be("ok");

        Console.WriteLine("Upserted 5 points.");

        //// Retrieve a specific point by its ID.

        var getPointResponse = await client.Points.GetPointAsync(
            collectionName: collectionName,
            id: 1);

        getPointResponse.Should().NotBeNull();
        getPointResponse.Status.Should().Be("ok");
        getPointResponse.Result.Should().NotBeNull();

        Console.WriteLine($"Retrieved point with ID: {getPointResponse.Result!.Id}");

        //// Count points in the collection.

        var countResponse = await client.Points.CountPointsAsync(
            collectionName: collectionName,
            exact: true);

        countResponse.Should().NotBeNull();
        countResponse.Result.Should().NotBeNull();
        countResponse.Result!.Count.Should().Be(5);

        Console.WriteLine($"Collection contains {countResponse.Result.Count} points.");

        //// Search for the 3 nearest neighbors using a query vector.

        var queryResponse = await client.Search.QueryPointsAsync(
            collectionName: collectionName,
            request: new QueryRequest
            {
                Query = new QueryInterface
                {
                    Value1 = new VectorInput
                    {
                        Value1 = new[] { 0.2f, 0.1f, 0.9f, 0.7f },
                    },
                },
                Limit = 3,
                WithPayload = true,
            });

        queryResponse.Should().NotBeNull();
        queryResponse.Status.Should().Be("ok");
        queryResponse.Result.Should().NotBeNull();
        queryResponse.Result!.Points.Should().HaveCount(3);

        foreach (var point in queryResponse.Result.Points)
        {
            Console.WriteLine($"Point ID: {point.Id}, Score: {point.Score}");
        }

        //// Delete specific points by ID.

        var deleteResponse = await client.Points.DeletePointsAsync(
            collectionName: collectionName,
            wait: true,
            request: new PointIdsList
            {
                Points = [1, 2],
            });

        deleteResponse.Should().NotBeNull();
        deleteResponse.Status.Should().Be("ok");

        //// Verify the remaining point count.

        var countAfterDelete = await client.Points.CountPointsAsync(
            collectionName: collectionName,
            exact: true);

        countAfterDelete.Result!.Count.Should().Be(3);

        Console.WriteLine("Deleted 2 points. 3 remaining.");

        //// Cleanup: delete the collection.

        await client.Collections.DeleteCollectionAsync(
            collectionName: collectionName);
    }
}
