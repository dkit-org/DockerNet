using Docker.DotNet;
using DockerNet.App.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace DockerNet.App;

public static class DIService
{
    public static IServiceCollection AddDockerNet( this IServiceCollection services)
    {
        // register external services
        services.AddScoped<IDockerClient, DockerClient>();
        
        // register docker net services
        services.AddScoped<IEngineService, EngineService>();
        return services;
    }
}