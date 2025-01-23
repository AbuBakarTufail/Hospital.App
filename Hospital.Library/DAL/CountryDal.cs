using Hospital.Library.Entities;
using Hospital.Library.Repository;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Library.DAL;

public class CountryDal : ICountry
{
    private readonly HmsContext context;
    
    public CountryDal(HmsContext context)
    {
        this.context = context;
    }

    public async Task<List<Country>> GetCountries() => await context.Countries.ToListAsync();
    
    public async Task<Country?> GetCountry(int countryId) => await context.Countries.FindAsync(countryId);
    
    public async Task<Country?> GetCountry(string countryName) => await context.Countries.FirstOrDefaultAsync(x=>x.Name == countryName);

    public async Task<bool> SaveCountry(Country country)
    {
        if (country.Id > 0)
        {
            Country? existingCountry = await context.Countries.FindAsync(country.Id);
            if (existingCountry != null)
            {
                existingCountry.Name = country.Name;
                existingCountry.DateModified = country.DateModified;
                existingCountry.ModifiedById = country.ModifiedById;
            }
        }
        else
        {
            await context.Countries.AddAsync(country);
        }
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteCountries(List<int> countryIds)
    {
        List<Country> countries = await context.Countries.Include(x => x.Cities).Where(x => countryIds.Contains(x.Id)).ToListAsync();
        if (countries != null && countries.Any())
        {
            context.Countries.RemoveRange(countries);
        }
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteCountry(int countryId)
    {
        Country? country = await context.Countries.Include(x => x.Cities).FirstOrDefaultAsync(x => x.Id == countryId);
        if (country != null)
        {
            context.Countries.Remove(country);
        }
        return await context.SaveChangesAsync() > 0;
    }
}
