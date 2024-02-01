using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblSpecialization")]
    public class Specialization:BaseEntity
    {
        public string Name { get; set; } = default!;
        public ICollection<Doctor>? Doctors { get; set; }
    }
}
