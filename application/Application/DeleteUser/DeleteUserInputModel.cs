namespace Application;

public class DeleteUserInputModel : BaseInputModel
{
    public readonly int? Id;

    public DeleteUserInputModel(int? id)
    {
        this.Id = id;
    }
}
