namespace Infra.Http.Controllers;

using Application.GetUserById;
using Infra.Model.User;

public class GetUserByIdController : BaseController<GetUserByIdModel, IResult>
{
    private GetUserById _usecase;

    public GetUserByIdController(GetUserById _usecase)
    {
        this._usecase = _usecase;
    }

    public override IResult Handle(GetUserByIdModel model)
    {
        var inputModel = new GetUserByIdInputModel {Id = model.Id};

        var view = _usecase.Handle(inputModel);

        return Results.Json(data: new {data = view}, statusCode: 200);
    }
}
