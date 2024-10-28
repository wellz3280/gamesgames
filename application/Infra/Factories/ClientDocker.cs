namespace Infra.Factories;

using Docker.DotNet;
using Domain.Interfaces;

public class ClientDocker : IDocker
{
    public DockerClient Initiate()
    {
        return new DockerClientConfiguration(
            new Uri("unix:///var/run/docker.sock"))
            .CreateClient();
    }
}
