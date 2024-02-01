using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblEmployeeType")]
    public class EmployeeType:BaseEntity
    {
        public string Name { get; set; } = default!;
        public ICollection<Employee>? Employees { get; set; }
    }
}
