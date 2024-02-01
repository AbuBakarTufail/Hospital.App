using Hospital.Library.Entities;
using Hospital.Library.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.App.Controllers.Configuration
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICity cityDal;
        public CityController(ICity city)
        {
            cityDal = city;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<City> cityList = await cityDal.GetCities();
            return Ok(await cityDal.GetCities());
        }
    }
}
