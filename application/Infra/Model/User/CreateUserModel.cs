namespace Infra.Model.User;

using System.Text.Json.Serialization;

public class CreateUserModel : IApiModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("last_name")]
    public string LastName {get; set;} = null!;

}
