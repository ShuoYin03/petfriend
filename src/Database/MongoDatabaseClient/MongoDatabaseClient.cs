using Microsoft.Extensions.Options;
using petfriend_api.Options;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using petfriend_api.Models;

namespace petfriend_api.Database.MongoDatabaseClient;

public class MongoDatabaseClient: IMongoDatabaseClient
{
    private readonly IMongoDatabase _mongoDatabase;
    private readonly IOptions<DatabaseOptions> _options;
    private readonly ILogger<MongoDatabaseClient> _logger;

    public MongoDatabaseClient(IOptions<DatabaseOptions> options, ILogger<MongoDatabaseClient> logger)
    {
        _logger = logger;
        _options = options;
        var client = new MongoClient(_options.Value.ConnectionString);
        _mongoDatabase = client.GetDatabase(_options.Value.DatabaseName);
    }

    public IMongoCollection<T> GetCollection<T>(string collectionName)
    {
        var collection = _mongoDatabase.GetCollection<T>(collectionName);
        _logger.LogWarning(collection.CollectionNamespace.CollectionName);
        return _mongoDatabase.GetCollection<T>(collectionName);
    }
}
    