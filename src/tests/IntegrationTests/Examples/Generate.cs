/*
order: 1
title: Test
slug: test
*/

namespace Qdrant.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Generate()
    {
        var client = Client;

        client.Aliases.HttpClient.Should().BeSameAs(client.HttpClient);
        client.Collections.HttpClient.Should().BeSameAs(client.HttpClient);
        client.Points.HttpClient.Should().BeSameAs(client.HttpClient);
        client.Search.HttpClient.Should().BeSameAs(client.HttpClient);
        client.Service.HttpClient.Should().BeSameAs(client.HttpClient);
        client.Snapshots.HttpClient.Should().BeSameAs(client.HttpClient);
    }
}
