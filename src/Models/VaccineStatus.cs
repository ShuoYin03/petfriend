namespace petfriend_api.Models;

public class VaccineStatus
{
    public bool IsVaccineComplete { get; set; } = false;
    public DateOnly? NextVaccinationDueDate { get; set; }
}