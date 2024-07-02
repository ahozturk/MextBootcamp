using Eventify.Domain;

namespace Eventify.Application;

public interface IEventService
{
    public void Add(EventAddDto eventAddDto);

    //eventService.Add(eventAddDto);
}
