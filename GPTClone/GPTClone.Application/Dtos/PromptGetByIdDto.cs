namespace GPTClone.Application;

public class PromptGetByIdDto
{
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public string Text { get; set; }
    public string Response { get; set; }
}
