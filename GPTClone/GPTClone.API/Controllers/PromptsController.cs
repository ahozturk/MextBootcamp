using GPTClone.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromptsController : ControllerBase
    {
        private readonly IPromptService _promptService;

        public PromptsController(IPromptService promptService)
        {
            _promptService = promptService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var prompts = _promptService.GetAll();
            return Ok(prompts);
        }

        [HttpPost]
        public IActionResult Create(PromptAddDto promptAddDto)
        {
            _promptService.Add(promptAddDto);
            return Ok();
        }
    }
}
