using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblGender")]
    public class Gender:BaseEntity
    {
        public string? Name { get; set; } = default!;
        public ICollection<Person>? Persons { get; set; }
    }
}
