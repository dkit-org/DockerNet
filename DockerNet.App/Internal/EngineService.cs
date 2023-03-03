using Docker.DotNet;
using DockerNet.App.Models;

namespace DockerNet.App.Internal;

internal class EngineService : IEngineService
{
    private readonly IDockerClient _dockerClient;

    public EngineService(IDockerClient dockerClient)
    {
        _dockerClient = dockerClient;
    }
    
    public async Task<ICollection<Engine>> GetAllEngines()
    {
        return new List<Engine>
        {
            new Engine {Id = 1, Name = "localhost", Host = "localhost", Port = ""}
        };
    }
}