using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblPatient")]
    public class Patient:BaseEntity
    {
        public int PersonId { get; set; }
        public Person? Person { get; set; }
        public int PatientTypeId { get; set; }
        public PatientType? PatientType { get; set; }
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public DateTime AppointmentTime { get; set; }
        public DateTime CheckUpDate { get; set; }
        public decimal CheckUpFee { get; set; }
        public DateTime? LastVisitDate { get; set; }
        public int TokenNumber { get; set; }
        public int PatientStatus { get; set; }
        public int PatientWeight { get; set; }
        public string PatientBloodPressure { get; set; } = default!;
    }
}
