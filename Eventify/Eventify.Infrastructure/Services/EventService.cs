using Eventify.Application;
using Eventify.Domain;
using Microsoft.EntityFrameworkCore;

namespace Eventify.Infrastructure;

public class EventService : IEventService
{
    private readonly EventifyDbContext _dbContext;

    public EventService(EventifyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(EventAddDto eventAddDto)
    {
        var newEvent = new Event
        {
            Id = Guid.NewGuid(),
            CreatedAt = DateTime.UtcNow,
            Title = eventAddDto.Title,
            Description = eventAddDto.Description,
            Date = eventAddDto.Date,
            Location = new Address
            {
                Street = eventAddDto.Location.Street,
                City = eventAddDto.Location.City,
                District = eventAddDto.Location.District,
                No = eventAddDto.Location.No,
                Note = eventAddDto.Location.Note,
                PostalCode = eventAddDto.Location.PostalCode,
            },
            Type = eventAddDto.Type
        };

        _dbContext.Events.Add(newEvent);

        _dbContext.SaveChanges();
    }

    public List<EventGetAllDto> GetAll()
    {
        return _dbContext.Events
        .AsNoTracking()
        .Select(x => new EventGetAllDto()
        {
            Id = x.Id,
            Title = x.Title,
            Description = x.Description,
            Date = x.Date,
            Location = new Address
            {
                Street = x.Location.Street,
                City = x.Location.City,
                District = x.Location.District,
                No = x.Location.No,
                Note = x.Location.Note,
                PostalCode = x.Location.PostalCode,
            },
            Type = x.Type
        })
        .ToList();
    }

    public EventGetByIdDto GetById(Guid id)
    {
        var eventData = _dbContext.Events
            .AsNoTracking()
            .Select(x => new EventGetByIdDto()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Date = x.Date,
                Location = x.Location,
                Type = x.Type,
            }).FirstOrDefault(x => x.Id == id);

            return eventData;
    }

    public void Update(Guid id, EventUpdateDto eventUpdateDto)
    {
        var existingEvent = _dbContext.Events
            .FirstOrDefault(x => x.Id == id);

        if (existingEvent == null)
            throw new Exception("Event not found");

        existingEvent.Title = eventUpdateDto.Title;
        existingEvent.Description = eventUpdateDto.Description;
        existingEvent.UpdatedAt = DateTime.UtcNow;

        _dbContext.SaveChanges();
    }
}
