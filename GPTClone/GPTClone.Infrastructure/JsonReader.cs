using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace GPTClone.Infrastructure;

public static class JsonReader
{
    public static string ReadJson(string key)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath($"{Directory.GetCurrentDirectory()}/../GPTClone.Infrastructure")
            .AddJsonFile("secrets.json")
            .Build();

        return configuration[key];
    }
}
