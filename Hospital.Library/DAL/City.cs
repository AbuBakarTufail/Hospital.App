using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Library.DAL
{
    [Table("tblCity")]
    public class City:BaseEntity
    {
        public string Name { get; set; } = default!;
        public int CountryId { get; set; }
        public Country? Country { get; set; }
    }
}
