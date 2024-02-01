using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblPatientType")]
    public class PatientType:BaseEntity
    {
        public string Name { get; set; } = default!;
        public ICollection<Patient>? Patients { get; set; }
    }
}
