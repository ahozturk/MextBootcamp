using Eventify.Application;
using Eventify.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            var events = _eventService.GetAll();

            return Ok(events);
        }

        [HttpPost]
        public IActionResult Create(EventAddDto eventAddDto)
        {
            _eventService.Add(eventAddDto);

            return Ok();
        }
    }
}
