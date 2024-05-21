using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeathersController : ControllerBase
    {
        [HttpGet]
        public int GetTempraure()
        {
            Random random = new();
            int temperature = random.Next(-20, 55);
            return temperature;
        }
    }
}
