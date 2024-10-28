namespace Infra.Services;

using Infra.Model;

public class DockerServiceView : IApiModel
{
    public string Id { get; set; }
    public string Image { get; set; }
    public string Command { get; set; }
    public string Created { get; set; }
    public string? Status { get; set; }
    public string Ports { get; set; }
    public long Size { get; set; }

    public DockerServiceView(
        string id,
        string image,
        string command,
        string created,
        string? status,
        string ports,
        long size
    )
    {
        Id = id;
        Image = image;
        Command = command;
        Created = created;
        Status = status;
        Ports = ports;
        Size = size;
    }
}
