namespace Eventity.Domain;

public class Event
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTimeOffset Date { get; set; }
    public Address Location { get; set; }
    public EventType Type { get; set; }
}
