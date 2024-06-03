using APIRecap;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        PersonService personService = new();

        [HttpPost("SavePerson")]
        public void SavePerson(string name)
        {
            personService.SavePerson(name);
        }

        [HttpPost("UpdatePerson")]
        public void UpdatePerson(string oldName, string newName)
        {
            personService.UpdatePerson(oldName, newName);
        }

        [HttpGet("GetPeople")]
        public List<string> GetPeople()
        {
            return personService.GetPeople();
        }


       
    }
}
