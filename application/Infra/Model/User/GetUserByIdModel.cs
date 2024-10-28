namespace Infra.Model.User;

using System.Text.Json.Serialization;

public class GetUserByIdModel: IApiModel
{
    [JsonPropertyName("id")]
    public int Id {get; set;}
}
