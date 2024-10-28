namespace Application.DeleteUser;

using Domain.Interfaces;

public class DeleteUser(IUsersRepository repository) : IService<DeleteUserInputModel, DeleteUserViewModel>
{
    public DeleteUserViewModel Handle(DeleteUserInputModel input)
    {
        var user = repository.GetUserById((int) input.Id);

        repository.Delete(user);

        return new DeleteUserViewModel();
    }
}
