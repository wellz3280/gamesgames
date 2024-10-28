namespace Infra.Http.Controllers;

using Application.UpdateUser;
using Infra.Model.User;

public class UpdateUserController(UpdateUser updateUser) : BaseController<UpdateUserModel, IResult>
{
    public override IResult Handle(UpdateUserModel input)
    {
        var id   = input.Id;
        var name = input.Name ?? null;
        var lastName = input.LastName ?? null;

        var view = updateUser.Handle(new UpdateUserInputModel(id, name, lastName));

        return Results.Json(data: view, statusCode: 204);

    }

}
