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
        public IActionResult GetAll()
        {
            var events = _eventService.GetAll();

            return Ok(events);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var eventData = _eventService.GetById(id);

            return Ok(eventData);
        }

        [HttpPost]
        public IActionResult Create(EventAddDto eventAddDto)
        {
            _eventService.Add(eventAddDto);

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, EventUpdateDto eventUpdateDto)
        {
            _eventService.Update(id, eventUpdateDto);

            return Ok();
        }
    }
}
