using Application.Docker.GetCurrentImage;
using Infra.Http.Controllers;
using Infra.Http.Controllers.Docker;
using Infra.Model.Docker;
using Infra.Model.User;
using Microsoft.AspNetCore.Mvc;

namespace Infra.Config;

public static class Routes
{
    public static void UseRoutes(IEndpointRouteBuilder builder)
    {
        builder.MapGet("/v1/ping", () => Results.Json(new {Ping = "Pong"}));
        builder.MapPost("/v1/users", ([FromBody] CreateUserModel input, [FromServices] CreateUserController controller) => {
            return controller.Handle(input);
        });

        builder.MapGet("/v1/users/{id}", (string id, [FromServices] GetUserByIdController controller) => {
            if (int.TryParse(id, out int userId)) {
                var model = new GetUserByIdModel {Id = userId};
                return controller.Handle(model);
            }

            return Results.BadRequest("Invalid Id");

        });

        builder.MapGet("/v1/users", ([FromServices] GetAllUsersController controller) => {
            return controller.Handle(new GetAllUsersModel());
        });

        builder.MapPut("/v1/users/{id}", (
            string id,
            [FromServices] UpdateUserController controller,
            [FromBody] UpdateUserModel model
        ) => {

            if (int.TryParse(id, out int userId)) {
                model.Id = userId;

                return controller.Handle(model);
            }

            return Results.BadRequest("Invalid Id");
        });

        builder.MapDelete("/v1/users/{id}", (string id, [FromServices] DeleteUserController controller) => {
             if (int.TryParse(id, out int userId)) {
                var model = new DeleteUserModel();
                model.Id = userId;

                return controller.Handle(model);
            }

            return Results.BadRequest("Invalid Id");
        });

        builder.MapGet("/v1/docker", ([FromServices] GetCurrentImageController controller) => {
            return controller.Handle(new GetCurrentImageModel());
        });
    }
}
