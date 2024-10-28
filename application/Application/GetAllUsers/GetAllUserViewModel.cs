namespace Application.GetAllUsers;

using System.Text.Json.Serialization;

public class GetAllUserViewModel(int? id, string name, string lastName) : BaseViewModel
{
    [JsonPropertyName("id")]
    public int? Id { get; set; } = id;

    [JsonPropertyName("name")]
    public string Name { get; set; } = name;

    [JsonPropertyName("last_name")]
    public string LastName { get; set; } = lastName;
}
