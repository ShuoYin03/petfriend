namespace petfriend_api.Models;

public class Address
{
    public string AddressLine1 { get; set; } = string.Empty;

    public string? AddressLine2 { get; set; }

    public string? County { get; set; }

    public string Country { get; set; } = string.Empty;

    public string PostCode { get; set; } = string.Empty;
    
    
    
}