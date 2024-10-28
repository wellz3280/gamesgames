namespace Domain.Interfaces;

using Docker.DotNet;

public interface IDocker
{
    public DockerClient Initiate();
}
