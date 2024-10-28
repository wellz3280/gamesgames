namespace Infra.Http.Controllers;

using Application;
using Application.DeleteUser;
using Infra.Model.User;

public class DeleteUserController(DeleteUser deleteUser) : IService<DeleteUserModel, IResult>
{
    public IResult Handle(DeleteUserModel input)
    {
        var view = deleteUser.Handle(new DeleteUserInputModel(input.Id));

        return Results.Json(data: view, statusCode: 204);
    }
}
