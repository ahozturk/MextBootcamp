﻿using System.Text;
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
                new { role = "user", content = text }
            },
            temperature = 0.7
        };
        
        var json = JsonSerializer.Serialize(requestBody);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        var response = await client.PostAsync(url, content);
        var responseString = await response.Content.ReadAsStringAsync();

        return responseString;
    }
}
