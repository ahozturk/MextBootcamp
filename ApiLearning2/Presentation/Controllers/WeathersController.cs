using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeathersController : ControllerBase
    {
        List<string> summaries1 = new() { "Freezing", "Refrigerate", "Frosty" };
        List<string> summaries2 = new() { "Cold", "Chiling", };
        List<string> summaries3 = new() { "Tepid", "Warm", "Balmy", "Mild" };
        List<string> summaries4 = new() { "Hot", "Scorching", "Sizzling" };

        [HttpGet]
        public string GetSummary()
        {
            Random random = new();
            int temperature = random.Next(-20, 55);
            string summary = "";

            if (temperature < 0)
                summary = summaries1[random.Next(summaries1.Count)];

            else if (temperature < 12)
                summary = summaries2[random.Next(summaries2.Count)];

            else if (temperature < 27)
                summary = summaries3[random.Next(summaries3.Count)];

            else if (temperature < 55)
                summary = summaries4[random.Next(summaries4.Count)];
            
            return $"Temperature: {temperature}°C, Summary: {summary}";
        }
    }
}
