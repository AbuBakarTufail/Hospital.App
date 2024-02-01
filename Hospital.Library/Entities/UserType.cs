using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblUserType")]
    public class UserType : BaseEntity
    {
        public string Name { get; set; } = default!;
        public ICollection<User>? Users { get; set; }
    }
}
