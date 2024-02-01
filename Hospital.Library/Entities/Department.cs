using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblDepartment")]
    public class Department:BaseEntity
    {
        public string Name { get; set; } = default!;
        public ICollection<Doctor>? Doctors { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
