namespace Hospital.App.Models.Configurations;

public class CountryModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CountryCode { get; set; }
    public string Flag { get; set; } = default!;
    //public List<CityModel>? Cities { get; set; }
}
