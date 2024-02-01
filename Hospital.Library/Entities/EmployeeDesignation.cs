using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblEmployeeDesignation")]
    public class EmployeeDesignation:BaseEntity
    {
        public string Name { get; set; } = default!;
        public ICollection<Employee>? Employees { get; set; }
    }
}
