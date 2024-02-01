using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblEmployeeRecord")]
    public class EmployeeRecord:BaseEntity
    {
        public DateTime? TerminationDate { get; set; }
        public string TerminationReason { get; set; } = default!;
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public decimal Salary { get; set; }
    }
}
