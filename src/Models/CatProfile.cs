namespace petfriend_api.Models;

public class CatProfile : PetProfile
{
    public bool IsIndoor { get; set; } = false;
    public bool IsMixed { get; set; } = false;
    public CatBreed Breed { get; set; } = CatBreed.NotKnown;
    public VaccineStatus VaccineStatus { get; set; } = new VaccineStatus();
}