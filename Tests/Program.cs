using Docker.DotNet;
using Docker.DotNet.Models;

var client = new DockerClientConfiguration().CreateClient();
var containers = await client.Containers.ListContainersAsync(new ContainersListParameters(){Limit = 10});
foreach (var containerListResponse in containers)
{
    Console.WriteLine(containerListResponse.ID);
    Console.WriteLine(containerListResponse.State);
    Console.WriteLine(containerListResponse.Status);
    foreach (var name in containerListResponse.Names)
    {
        Console.WriteLine(name);
    }
    
    foreach (var port in containerListResponse.Ports)
    {
        Console.WriteLine($"{port.PrivatePort}:{port.PublicPort}");
    }

    Console.WriteLine("====================================================");

}