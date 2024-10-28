namespace Infra.Http.Controllers.Docker;

using Application.Docker.GetCurrentImage;
using Infra.Model.Docker;

public class GetCurrentImageController(GetCurrentImage usecase) : BaseController<GetCurrentImageModel, IResult>
{
    public override IResult Handle(GetCurrentImageModel input)
    {
        var view = usecase.Handle(new GetCurrentImageInputModel());

        return Results.Json(data: view, statusCode: 200);
    }
}
