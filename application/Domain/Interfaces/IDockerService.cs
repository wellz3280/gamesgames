namespace Domain.Interfaces;

using Infra.Services;

public interface IDockerService
{
    public Task<List<DockerServiceView>> ListCurrentImages();
}
