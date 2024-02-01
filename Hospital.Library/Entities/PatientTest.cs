using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblPatientTest")]
    public class PatientTest:BaseEntity
    {
        public string Detail { get; set; } = default!;
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public int TokenNumber { get; set; }
        public DateTime DoctorMedicineDate { get; set; }

    }
}
