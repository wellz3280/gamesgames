namespace Infra.Http.Controllers;

using Application.GetAllUsers;
using Infra.Model.User;

public class GetAllUsersController(GetAllUsers usecase) : BaseController<GetAllUsersModel, IResult>
{
    private readonly GetAllUsers usecase = usecase;

    public override IResult Handle(GetAllUsersModel input)
    {
        var view = this.usecase.Handle(new GetAllUserInputModel());

        return Results.Json(data: new{ data = view}, statusCode: 200);
    }
}
