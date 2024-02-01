using Hospital.Library.Entities;
using Hospital.Library.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Library.DAL
{
    public class CityDal:ICity
    {
        private readonly HmsContext context;
        public CityDal(HmsContext context)
        {
            this.context = context;
        }
        public async Task<List<City>> GetCities() => await context.Cities.ToListAsync();
    }
}
