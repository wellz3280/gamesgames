namespace Application.GetAllUsers;

using Infra.Factories;

public class GetAllUsers(ClientSqlite client) : IService<GetAllUserInputModel, List<GetAllUserViewModel>>
{
    public List<GetAllUserViewModel> Handle(GetAllUserInputModel input)
    {
        var users = client.Users.ToList();

        return users.Select(x => new GetAllUserViewModel(x.Id, x.Name, x.LastName)).ToList();
    }
}
