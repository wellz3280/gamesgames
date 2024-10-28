namespace Application.UpdateUser;

public class UpdateUserInputModel : BaseInputModel
{
    public readonly int? Id;

    public readonly string? Name;

    public readonly string? LastName;

    public UpdateUserInputModel(int? id, string? name, string? lastName)
    {
        this.Id = id;
        this.Name = name;
        this.LastName = lastName;
    }

}
