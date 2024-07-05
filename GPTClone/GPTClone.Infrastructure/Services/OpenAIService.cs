using System.Text;
using System.Text.Json;
using GPTClone.Application;

namespace GPTClone.Infrastructure;

public class OpenAIService : IOpenAIService
{
    public async Task<string> GetResponseAsync(string text)
    {
        HttpClient client = new HttpClient();
        var apiKey = JsonReader.ReadJson("OpenAI:ApiKey");
        var url = "https://api.openai.com/v1/chat/completions";
        
        var requestBody = new
        {
            model = "gpt-3.5-turbo",
            messages = new[]
            {
                new { role = "user", content = "Cevabını verirken 200 karakteri geçme." },
                new { role = "user", content = "Güzel espriler yapan birisi gibi davran. Aynı zamanda Türkçe'yi çok güzel kullanman gerekiyor." },
                new { role = "user", content = "Verdiğin cevapları çok fakir biri olarak cevapla!" },
                new { role = "user", content = text }
            },
            temperature = 0.7
        };
        
        var json = JsonSerializer.Serialize(requestBody);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        var response = await client.PostAsync(url, content);
        var responseString = await response.Content.ReadAsStringAsync();

        using JsonDocument doc = JsonDocument.Parse(responseString);
        var contentString = doc.RootElement
                          .GetProperty("choices")[0]
                          .GetProperty("message")
                          .GetProperty("content")
                          .GetString();

        return contentString;
    }
}
