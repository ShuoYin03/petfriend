using MongoDB.Driver;

namespace petfriend_api.Database.MongoDatabaseClient;

public interface IMongoDatabaseClient
{
    IMongoCollection<T> GetCollection<T>(string collectionName);
}