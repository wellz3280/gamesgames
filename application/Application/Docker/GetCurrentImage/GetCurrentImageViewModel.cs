namespace Application.Docker.GetCurrentImage;

using System.Text.Json.Serialization;

public class GetCurrentImageViewModel(
        string id,
        string image,
        string comamnd,
        string created,
        string status,
        string ports,
        long size
    ) : BaseViewModel {

    [JsonPropertyName("id")]
    public string Id { get; set; } = id;

    [JsonPropertyName("image")]
    public string Image { get; set; } = image;

    [JsonPropertyName("command")]
    public string Comamnd { get; set; } = comamnd;

    [JsonPropertyName("created")]
    public string Created { get; set; } = created;

    [JsonPropertyName("status")]
    public string Status { get; set; } = status;

    [JsonPropertyName("ports")]
    public string Ports { get; set; } = ports;

    [JsonPropertyName("size")]
    public long Size { get; set; } = size;

}

