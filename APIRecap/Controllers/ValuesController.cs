using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<string> people = new();

        [HttpPost("SavePerson")]
        public void SavePerson(string name)
        {
            people.Add(name);
            Console.WriteLine($"Added {name}");
        }

        [HttpPost("UpdatePerson")]
        public void UpdatePerson(string oldName, string newName)
        {
            foreach (var person in people)
            {
                if (person == oldName)
                {
                    people.Remove(person);
                    people.Add(newName);
                    Console.WriteLine($"Updated {oldName} to {newName}");
                    break;
                }
            }
        }

        [HttpGet("GetPeople")]
        public List<string> GetPeople()
        {
            return people;
        }


       
    }
}
