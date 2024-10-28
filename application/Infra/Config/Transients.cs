namespace Infra.Config;

using Application.CreateUser;
using Application.DeleteUser;
using Application.Docker.GetCurrentImage;
using Application.GetAllUsers;
using Application.GetUserById;
using Application.UpdateUser;
using Domain.Interfaces;
using Infra.Factories;
using Infra.Http.Controllers;
using Infra.Http.Controllers.Docker;
using Infra.Repositories;
using Infra.Services;

public static class Transients
{
    public static IServiceCollection AddApplicationTransients(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRepositories();
        services.AddUsecase();
        services.AddControllers();
        services.AddContext();
        services.AddExternalServices();

        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<IUsersRepository, UserRepository>();

        return services;
    }

    private static IServiceCollection AddUsecase(this IServiceCollection services)
    {
        services.AddTransient<CreateUser>();
        services.AddTransient<GetUserById>();
        services.AddTransient<GetAllUsers>();
        services.AddTransient<UpdateUser>();
        services.AddTransient<DeleteUser>();
        services.AddTransient<GetCurrentImage>();

        return services;
    }

    private static IServiceCollection AddControllers(this IServiceCollection services)
    {
        services.AddTransient<CreateUserController>();
        services.AddTransient<GetUserByIdController>();
        services.AddTransient<GetAllUsersController>();
        services.AddTransient<UpdateUserController>();
        services.AddTransient<DeleteUserController>();
        services.AddTransient<GetCurrentImageController>();

        return services;
    }

    private static IServiceCollection AddContext(this IServiceCollection services)
    {
        services.AddTransient<ClientSqlite>();
        services.AddDbContext<ClientSqlite>();

        return services;
    }

    private static IServiceCollection AddExternalServices(this IServiceCollection services)
    {
        services.AddTransient<IDocker, ClientDocker>();
        services.AddTransient<IDockerService, DockerService>();

        return services;
    }
}
