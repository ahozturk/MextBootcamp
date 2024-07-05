using GPTClone.Application;

namespace GPTClone.Infrastructure;

public class OpenAIService : IOpenAIService
{
    public string GetResponse(string text)
    {
        return "Response from OpenAI";
    }
}
