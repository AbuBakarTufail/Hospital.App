using Hospital.App.Models.Configurations;
using Hospital.Library.Entities;
using Hospital.Library.Helper;
using Hospital.Library.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.App.Controllers.Configuration;

[Route("api/[controller]/[action]")]
[ApiController]
public class CountryController : ControllerBase
{
    private readonly ICountry countryDal;
    public CountryController(ICountry country)
    {
        countryDal = country;
    }

    [HttpGet]
    public async Task<IActionResult> GetCountries()
    {
        List<CountryModel> countries = new();
        List<Country> countryList = await countryDal.GetCountries();
        if (countryList != null && countryList.Any())
        {
            foreach (Country country in countryList)
            {
                countries.Add(new()
                {
                    Id = country.Id,
                    Name = country.Name,
                    Flag = country.Flag,
                    CountryCode = country.CountryCode,
                });
            }
        }
        return Ok(countries);
    }

    [HttpGet]
    public async Task<IActionResult> GetCountry(string searchBy, int countryId = 0, string countryName = "")
    {
        CountryModel country = new();
        Country? searchCountry = new();
        if (!string.IsNullOrWhiteSpace(searchBy))
        {
            if (searchBy == "Id")
                searchCountry = await countryDal.GetCountry(countryId);
            else if (searchBy == "Name")
                searchCountry = await countryDal.GetCountry(countryName);
            if (searchCountry != null)
            {
                country = new()
                {
                    Id = searchCountry.Id,
                    Name = searchCountry.Name,
                    Flag = searchCountry.Flag,
                    CountryCode = searchCountry.CountryCode,
                };
            }
            else
            {
                return NotFound(Common.NotFoundErrorMessage);
            }
        }
        else
        {
            return NotFound("Please specify searchby option for perceding next.");
        }
        return Ok(country);
    }

    [HttpPost]
    public async Task<IActionResult> SaveCountry(CountryModel model)
    {
        bool isSaved = false;
        if (model != null)
        {
            Country country = new()
            {
                Id = model.Id,
                Name = model.Name,
                Flag = model.Flag,
                CountryCode = model.CountryCode,
            };
            isSaved = await countryDal.SaveCountry(country);
        }
        else
        {
            return NotFound(Common.NotFoundErrorMessage);
        }
        return Ok(isSaved);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCountry(int countryId)
    {
        bool isDeleted = await countryDal.DeleteCountry(countryId);
        return Ok(isDeleted);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCountries(List<int> countryIds)
    {
        bool isDeleted = await countryDal.DeleteCountries(countryIds);
        return Ok(isDeleted);
    }
}
