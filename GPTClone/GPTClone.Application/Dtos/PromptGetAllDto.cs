namespace GPTClone.Application;

public class PromptGetAllDto
{
    public Guid Id { get; set; }
    public string CreatedBy { get; set; }
    public string Text { get; set; }
    public string Response { get; set; }
}
