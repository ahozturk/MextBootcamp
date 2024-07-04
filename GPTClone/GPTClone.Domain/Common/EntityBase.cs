namespace GPTClone.Domain;

public class EntityBase
{
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public string CreatedBy { get; set; }
}
