using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Library.Entities
{
    [Table("tblUser")]
    public class User:BaseEntity
    {
        public int PersonId { get; set; }
        public Person? Person { get; set; }
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public bool IsActive { get; set; }
        public int DoctorEmployeeId { get; set; }
        public int UserTypeId { get; set; }        
        public UserType? UserType { get; set; }
    }
}
