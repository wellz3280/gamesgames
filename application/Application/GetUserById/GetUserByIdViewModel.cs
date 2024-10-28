namespace Application.GetUserById;

using System.Text.Json.Serialization;

public class GetUserByIdViewModel: BaseViewModel
{

    [JsonPropertyName("id")]
    public int Id {get; set;}

    [JsonPropertyName("name")]
    public string Name {get ; set;}

    [JsonPropertyName("last_name")]
    public string LastName {get; set;}

    public GetUserByIdViewModel(int Id, string Name, string LastName)
    {
        this.Id = Id;
        this.Name = Name;
        this.LastName = LastName;
    }
}
