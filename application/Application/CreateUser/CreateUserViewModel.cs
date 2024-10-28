namespace Application.CreateUser;

using System.Text.Json.Serialization;

public class CreateUserViewModel: BaseViewModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("full_name")]
    public string FullName {get; set;}

    public CreateUserViewModel(string Name, string LastName, string FullName)
    {
        this.Name = Name;
        this.LastName = LastName;
        this.FullName = FullName;
    }
}
