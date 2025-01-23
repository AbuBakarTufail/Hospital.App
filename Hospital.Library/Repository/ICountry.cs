using Hospital.Library.Entities;

namespace Hospital.Library.Repository;

public interface ICountry
{
    public Task<List<Country>> GetCountries();
    public Task<Country?> GetCountry(int countryId);
    public Task<Country?> GetCountry(string countryName);
    public Task<bool> SaveCountry(Country country);
    public Task<bool> DeleteCountry(int countryId);
    public Task<bool> DeleteCountries(List<int> countryIds);
}
