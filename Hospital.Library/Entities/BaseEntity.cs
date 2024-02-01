using System.ComponentModel.DataAnnotations;

namespace Hospital.Library.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
    }
}
