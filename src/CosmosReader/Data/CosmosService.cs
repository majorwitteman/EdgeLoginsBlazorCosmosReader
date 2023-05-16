using Azure.Identity;
using Microsoft.Azure.Cosmos;

namespace CosmosReader.Data;

class CosmosService
{
    private readonly Container _container;
    public CosmosService (IConfiguration config) {
        CosmosClient _client = new(
            accountEndpoint: config.GetValue<string>("COSMOS_ENDPOINT"),
            tokenCredential: new DefaultAzureCredential()
        );
        Database database = _client.GetDatabase("edgeLogins");
        _container = database.GetContainer("logins");
    }

    public async Task<LoginData[]> GetAllDocuments() {
        var query = new QueryDefinition("SELECT * FROM logins");
        using FeedIterator<LoginData> feed = _container.GetItemQueryIterator<LoginData>(query);

        List<LoginData> logins = new();
        while (feed.HasMoreResults)
        {
            FeedResponse<LoginData> response = await feed.ReadNextAsync();
            logins.AddRange(response);
        }

        return logins.ToArray();
    }

    public async Task DeleteAllDocuments() {
        var documents = await GetAllDocuments();
        foreach (var doc in documents)
        {
            var key = new PartitionKeyBuilder();
            key.Add(doc.Username);
            await  _container.DeleteItemStreamAsync(doc.Id, key.Build());
        }
    }
}