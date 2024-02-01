using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Library.DAL
{
    [Table("tblUserType")]
    public class UserType:BaseEntity
    {
        public string Name { get; set; } = default!;        
        public ICollection<User>? Users { get; set; }
    }
}
