using Microsoft.AspNetCore.Http.HttpResults;
using MongoDB.Driver;
using petfriend_api.Models;
using Microsoft.Extensions.Logging;
using petfriend_api.Database.MongoDatabaseClient;

namespace petfriend_api.Database;
public class OwnerProfileCollection
{
    private readonly ILogger<OwnerProfileCollection> _logger;
    private readonly IMongoCollection<OwnerProfile> _ownerProfileCollection;
    
    public OwnerProfileCollection(IMongoDatabaseClient mongoDatabaseClient, ILogger<OwnerProfileCollection> logger)
    {
        _logger = logger;
        _ownerProfileCollection = mongoDatabaseClient.GetCollection<OwnerProfile>("OwnerProfile");
    }

    public async Task InsertOwnerAsync(OwnerProfile ownerProfile)
    { 
        await _ownerProfileCollection.InsertOneAsync(ownerProfile);
        return Ok;
    }

    public async Task<List<OwnerProfile>> GetAllOwnersAsync()
    {
        var filter = Builders<OwnerProfile>.Filter.Empty;
        return await _ownerProfileCollection.Find(filter).ToListAsync();
    }
}