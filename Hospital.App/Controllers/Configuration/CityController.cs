using Hospital.App.Models.Configurations;
using Hospital.Library.Entities;
using Hospital.Library.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.App.Controllers.Configuration
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICity cityDal;
        public CityController(ICity city)
        {
            cityDal = city;
        }

        [HttpGet]
        public async Task<IActionResult> GetCities(int countryId = 0)
        {
            List<City> cityList = await cityDal.GetCities(countryId);
            List<CityModel> cities = new();
            if (cityList != null && cityList.Any())
            {
                foreach (City city in cityList)
                {
                    cities.Add(new()
                    {
                        Id = city.Id,
                        Name = city.Name,
                        CountryId = city.CountryId,
                        CountryName = city.Country?.Name ?? string.Empty
                    });
                }
            }
            return Ok(cities);
        }

        [HttpGet]
        public async Task<IActionResult> GetCity(int cityId)
        {
            CityModel model = new();
            City? city = await cityDal.GetCity(cityId);
            if (city != null)
            {
                {
                    model.Id = city.Id;
                    model.Name = city.Name;
                    model.CountryId = city.CountryId;
                    model.CountryName = city.Country?.Name ?? string.Empty;
                }
            }
            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> SaveCity(City city)
        {
            return Ok(await cityDal.SaveCity(city));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCity(int cityId)
        {
            return Ok(await cityDal.DeleteCity(cityId));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCities(List<int> cityIds)
        {
            return Ok(await cityDal.DeleteCities(cityIds));
        }
    
    }
}
