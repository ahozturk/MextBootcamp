using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        static List<string> names = new();

        [HttpPost]
        public void AddName(string name)
        {
            names.Add(name);
            Console.WriteLine($"{name} name added successfully.");
        }

        [HttpGet("[action]")]
        public List<string> GetNames()
        {
            return names;
        }

        [HttpGet("[action]")]
        public string GetRandomName()
        {
            Random random = new();
            int randomIndex = random.Next(names.Count);
            return names[randomIndex];
        }
    }
}
