using Hospital.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Library.Repository
{
    public interface ICity
    {
        public Task<List<City>> GetCities();
    }
}
