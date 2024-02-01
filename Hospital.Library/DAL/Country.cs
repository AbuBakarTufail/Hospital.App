using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Library.DAL
{
    [Table("tblCountry")]
    public class Country:BaseEntity
    {
        public string Name { get; set; } = default!;
        public ICollection<City>? Cities { get; set; }

    }
}
