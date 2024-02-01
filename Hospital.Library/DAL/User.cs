using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Library.DAL
{
    [Table("tblUser")]
    public class User:BaseEntity
    {
        public string Name { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public bool IsActive { get; set; }
        public int DoctorEmployeeId { get; set; }
        public int UserTypeId { get; set; }        
        public UserType? UserType { get; set; }
    }
}
