using Eventify.Domain;

namespace Eventify.Application;

public interface IEventService
{
    public void Add(EventAddDto eventAddDto);
    public List<EventGetAllDto> GetAll();
    public EventGetByIdDto GetById(Guid id);
    public void Update(Guid id, EventUpdateDto eventUpdateDto);
}
