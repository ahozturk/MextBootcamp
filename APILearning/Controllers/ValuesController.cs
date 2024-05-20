using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        List<string> nameList = new()
        {
            "Fatima",
            "Merve",
            "Şeyda",
        };

        [HttpGet("[action]")]
        public string GetName()
        {
            return nameList[0];
        }

        [HttpGet("[action]")]
        public float GetPiNumber()
        {
            return 3.14f;
        }

        [HttpGet("[action]")]
        public int GetTemperature()
        {
            return 18;
        }
    }
}
