namespace DockerNet.API.Models;

public class DockerEngine
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Host { get; set; }
    public string Port { get; set; }
}