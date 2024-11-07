namespace petfriend_api.Options;
public class DatabaseOptions
{
    public const string SectionName = "DatabaseOptions";
    public string? ConnectionString { get; set; } = "mongodb+srv://shuoyin03:Qazsedcft123qa@petfriend.y3lt0.mongodb.net/?retryWrites=true&w=majority&appName=PetFriend";
    public string? DatabaseName { get; set; } = "PetFriend";
}