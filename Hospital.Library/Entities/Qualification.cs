using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblQualification")]
    public class Qualification:BaseEntity
    {
        public string Name { get; set; } = default!;
    }
}
