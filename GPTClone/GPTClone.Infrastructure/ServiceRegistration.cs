using GPTClone.Application;
using Microsoft.Extensions.DependencyInjection;

namespace GPTClone.Infrastructure;

public static class ServiceRegistration
{
    public static void AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<GPTCloneDbContext>();

        services.AddScoped<IPromptService, PromptService>();
    }
}
