namespace Application.GetUserById;

using Domain.Error;
using Domain.Interfaces;

public class GetUserById(IUsersRepository usersRepository): IService<GetUserByIdInputModel, GetUserByIdViewModel>
{

    public GetUserByIdViewModel Handle(GetUserByIdInputModel input)
    {
        var user = usersRepository.GetUserById((int) input.Id);

        return new GetUserByIdViewModel((int) user.Id, user.Name, user.LastName);
    }
}
