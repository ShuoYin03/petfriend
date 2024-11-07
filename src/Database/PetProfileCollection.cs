// using MongoDB.Driver;
// using petfriend_api.Models;
// using System.Collections.Generic;
// using System.Threading.Tasks;

// namespace petfriend_api.Services;
// public class MongoDbService
// {

//     private readonly IMongoCollection<PetProfile> _petCollection;

//     public MongoDbService()
//     {
//         var client = new MongoClient("your_mongodb_connection_string");
//         var database = client.GetDatabase("petfriend_apiDb");qd
//         _petCollection = database.GetCollection<PetProfile>("PetProfiles");
//     }

//     public async Task<List<PetProfile>> GetAllPetsAsync()
//     {
//         return await _petCollection.Find(pet => true).ToListAsync();
//     }
// }