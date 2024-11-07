namespace petfriend_api.Models;
public class PetProfile
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; } = 0;
    public Species Species { get; set; }
    public Gender Gender { get; set; }
    public DateOnly? DateOfBirth { get; set; }
    public string ProfilePicture { get; set; } = string.Empty;
}