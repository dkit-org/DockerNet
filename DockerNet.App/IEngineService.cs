using DockerNet.App.Models;

namespace DockerNet.App;

public interface IEngineService
{
    public Task<ICollection<Engine>> GetAllEngines();
}