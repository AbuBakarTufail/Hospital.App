namespace Hospital.App.Models.Configurations
{
    public class CityModel
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; } = default!;
        public string CountryName { get; set; } = default!;
    }
}
