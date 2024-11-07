using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace petfriend_api.Models;

public class OwnerProfile
{
    [BsonId]
    public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
    
    [BsonElement("firstName")]
    public string FirstName { get; set; } = string.Empty;

    [BsonElement("lastName")]
    public string LastName { get; set; } = string.Empty;

    [BsonElement("userName")]
    public string Username { get; set; } = string.Empty;

    [BsonElement("email")]
    public string Email { get; set; } = string.Empty;

    [BsonElement("phone")]
    public string Phone { get; set; } = string.Empty;

    [BsonElement("gender")]
    public Gender Gender { get; set; }

    [BsonElement("dob")]
    public DateTime DateOfBirth { get; set; }

    [BsonElement("address")]
    public Address Address { get; set; } = new Address();

    [BsonElement("profilePicture")]
    public string ProfilePicture { get; set; } = string.Empty;

    [BsonElement("pets")]
    public List<PetProfile> Pets { get; set; } = new List<PetProfile>();
}