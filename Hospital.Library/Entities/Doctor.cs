using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblDoctor")]
    public class Doctor:BaseEntity
    {
        public int PersonId { get; set; }
        public Person? Person { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int SpecializationId { get; set; }
        public Specialization? Specialization { get; set; }
        public ICollection<Patient>? Patients { get; set; }
    }
}
