namespace DockerNet.App.Models;

public class Engine
{
    public required int Id { get; init; }
    public required string Name { get; set; }
    public required string Host { get; set; }
    public required string Port { get; set; }
}