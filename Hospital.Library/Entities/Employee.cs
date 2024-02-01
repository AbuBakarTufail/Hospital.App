using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblEmployee")]
    public class Employee:BaseEntity
    {
        public int PersonId { get; set; }
        public Person? Person { get; set; }
        [MaxLength(10)]
        public string EmployeeNumber { get; set; } = default!;
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int EmployeeTypeId { get; set; }
        public EmployeeType? EmployeeType { get; set; }
        public int EmployeeDesignationId { get; set; }
        public EmployeeDesignation? EmployeeDesignation { get; set; }
        public DateTime? JoiningDate { get; set; }
        public ICollection<EmployeeRecord>? EmployeeRecords { get; set; }

    }
}
