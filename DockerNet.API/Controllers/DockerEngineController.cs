using DockerNet.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DockerNet.API.Controllers;

[ApiController]
[Route("/runtime")]
public class DockerEngineController
{
     public Task<ICollection<DockerEngine>> GetDockerEngines()
     {
     }
}