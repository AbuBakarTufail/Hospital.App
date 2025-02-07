using Hospital.Library.Entities;

namespace Hospital.Library.Repository;

public interface ICity
{
    public Task<List<City>> GetCities(int countryId = 0);
    public Task<City?> GetCity(int cityId);
    public Task<bool> SaveCity(City city);
    public Task<bool> DeleteCity(int cityId);
    public Task<bool> DeleteCities(int countryId);
    public Task<bool> DeleteCities(List<int> cityIds);
}
