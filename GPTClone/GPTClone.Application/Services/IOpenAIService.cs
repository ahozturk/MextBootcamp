namespace GPTClone.Application;

public interface IOpenAIService
{
    string GetResponse(string text);
}
