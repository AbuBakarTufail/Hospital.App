using Hospital.Library.Entities;
using Hospital.Library.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

        public async Task<List<City>> GetCities(int countryId = 0)
        {
            if (countryId > 0)
            {
                return await context.Cities.Include(x => x.Country).Where(x => x.CountryId == countryId).ToListAsync();
            }
            else
            {
                return await context.Cities.Include(x => x.Country).ToListAsync();
            }
        }

        public async Task<City?> GetCity(int cityId) => await context.Cities.FindAsync(cityId);
        
        public async Task<bool> SaveCity(City city)
        {
            
            if (city.Id > 0)
            {
                City? existingCity = await context.Cities.FindAsync(city.Id);
                if (existingCity != null)
                {
                    existingCity.Name = city.Name;
                    existingCity.CountryId = city.CountryId;
                    existingCity.ModifiedById = city.ModifiedById;
                    existingCity.DateModified = DateTime.Now;
                }
            }
            else
            {
                city.DateCreated = DateTime.Now;
                city.DateModified = DateTime.Now;
                await context.Cities.AddAsync(city);
            }
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteCity(int cityId)
        {
            EntityEntry<City> cityRec = context.Cities.Attach(new City { Id = cityId });
            cityRec.State = EntityState.Deleted;
            return await context.SaveChangesAsync() > 0;
        }
        
        public async Task<bool> DeleteCities(int countryId)
        {
            List<City> cityRecs = await context.Cities.Where(x => x.CountryId == countryId).ToListAsync();
            if (cityRecs != null && cityRecs.Any())
            {
                context.Cities.RemoveRange(cityRecs);
            }
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteCities(List<int> cityIds)
        {
            List<City> cityRecs = await context.Cities.Where(x => cityIds.Contains(x.Id)).ToListAsync();
            if (cityRecs != null && cityRecs.Any())
            {
                context.Cities.RemoveRange(cityRecs);
            }
            return await context.SaveChangesAsync() > 0;
        }


    }
}
