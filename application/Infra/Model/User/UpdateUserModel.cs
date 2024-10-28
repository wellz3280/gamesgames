namespace Infra.Model.User;

using System.Text.Json.Serialization;

public class UpdateUserModel : IApiModel
{
    public int? Id {get; set;}

    [JsonPropertyName("name")]
    public string? Name {get; set;}

    [JsonPropertyName("last_name")]
    public string? LastName {get; set;}
}
