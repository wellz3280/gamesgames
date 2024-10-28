namespace Application.UpdateUser;

using Domain.Interfaces;

public class UpdateUser(IUsersRepository repository) : IService<UpdateUserInputModel, UpdateUserViewModel>
{
    public UpdateUserViewModel Handle(UpdateUserInputModel input)
    {
        var user = repository.GetUserById((int) input.Id);

        if (input.Name is not null) {
            user.Name = input.Name;
        }
        if (input.LastName is not null) {
            user.LastName = input.LastName;
        }

        repository.Update(user);

        return new UpdateUserViewModel();
    }
}
