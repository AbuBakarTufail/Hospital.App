using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblDisease")]
    public class Disease:BaseEntity
    {
        public string Name { get; set; } = default!;
    }
}
