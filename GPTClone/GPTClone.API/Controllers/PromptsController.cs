using GPTClone.Application;
using GPTClone.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromptsController : ControllerBase
    {
        private readonly IPromptService _promptService;
        private readonly IOpenAIService _openAIService;

        public PromptsController(IPromptService promptService, IOpenAIService openAIService)
        {
            _promptService = promptService;
            _openAIService = openAIService;
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

        [HttpGet("[action]")]
        public IActionResult AskToGPT(string promptText, string createdBy)
        {
            return Ok();
        }
    }
}
