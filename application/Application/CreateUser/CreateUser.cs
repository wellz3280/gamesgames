namespace Application.CreateUser;

using Domain.Entities;
using Domain.Interfaces;

public class CreateUser(IUsersRepository usersRepository) : IService<CreateUserInputModel, CreateUserViewModel>
{
    public CreateUserViewModel Handle(CreateUserInputModel input)
    {
        int? id = input.Id ?? null;

        var user = new User(
            id,
            input.Name,
            input.LastName
        );

        usersRepository.Save(user);

        return new CreateUserViewModel(user.Name, user.LastName, user.GetFullName());
    }
}
