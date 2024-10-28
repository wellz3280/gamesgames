namespace Infra.Http.Controllers;

using Application.CreateUser;
using Infra.Model.User;

public class CreateUserController : BaseController<CreateUserModel, IResult>
{
    private CreateUser _createUser;

    public CreateUserController(CreateUser _createUser)
    {
        this._createUser = _createUser;
    }

    public override IResult Handle(CreateUserModel input)
    {
        var userInput       = new CreateUserInputModel();
        userInput.Name      = input.Name;
        userInput.LastName  = input.LastName;

        var view = _createUser.Handle(userInput);

        return Results.Json(data: new {data = view}, statusCode: 201);
    }
}
