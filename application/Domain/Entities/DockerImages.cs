namespace Domain.Entities;

public class DockerImages(string image, string comamnd, string created, string status, string ports, long size) : BaseEntity
{
    public string Image { get; set; } = image;

    public string Comamnd { get; set; } = comamnd;

    public string Created { get; set; } = created;

    public string Status { get; set; } = status;

    public string Ports { get; set; } = ports;

    public long Size { get; set; } = size;
}
