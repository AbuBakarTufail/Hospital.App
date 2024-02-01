using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblCity")]
    public class City:BaseEntity
    {
        public string Name { get; set; } = default!;
        public int CountryId { get; set; }
        public Country? Country { get; set; }
        public ICollection<Person>? Persons { get; set; }
    }
}
