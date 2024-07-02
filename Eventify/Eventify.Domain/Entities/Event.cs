namespace Eventify.Domain;

public class Event : EntityBase
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTimeOffset Date { get; set; }
    public Address Location { get; set; }
    public EventType Type { get; set; }
}
