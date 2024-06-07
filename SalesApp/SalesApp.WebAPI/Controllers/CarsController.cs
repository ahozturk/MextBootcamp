using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesApp.Domain.Entities;
using SalesApp.Domain.Services;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        CarService carService = new CarService();

        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            car.Id = Guid.NewGuid();
            carService.Add(car);
            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult PrintToConsole()
        {
            carService.PrintConsole();
            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            List<Car> cars = carService.GetAll();
            return Ok(cars);
        }

    }
}
