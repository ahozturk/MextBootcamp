namespace GPTClone.Application;

public interface IOpenAIService
{
    Task<string> GetResponseAsync(string text);
}
