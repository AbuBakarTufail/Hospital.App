using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities;

[Table("tblCountry")]
public class Country:BaseEntity
{
    public string Name { get; set; } = default!;
    public int CountryCode { get; set; }
    public string Flag { get; set; } = default!;
    public ICollection<City>? Cities { get; set; }
}
