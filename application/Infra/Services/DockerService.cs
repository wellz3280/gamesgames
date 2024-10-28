namespace Infra.Services;

using Docker.DotNet.Models;
using Domain.Interfaces;

public class DockerService(IDocker docker) : IDockerService
{
    public async Task<List<DockerServiceView>> ListCurrentImages()
    {
        var containers = await docker.Initiate().Containers.ListContainersAsync(
            new ContainersListParameters() {Limit = 10});

        return containers.Select(x => new DockerServiceView(
            x.ID,
            x.Image,
            x.Command,
            x.Created.ToString(),
            x.Status,
            x.Ports.ToString(),
            x.SizeRw
        )).ToList();
    }
}
