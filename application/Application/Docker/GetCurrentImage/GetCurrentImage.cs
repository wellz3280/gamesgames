namespace Application.Docker.GetCurrentImage;

using Domain.Interfaces;

public class GetCurrentImage(IDockerService docker) : IService<GetCurrentImageInputModel, Task<List<GetCurrentImageViewModel>>>
{
    public async Task<List<GetCurrentImageViewModel>> Handle(GetCurrentImageInputModel input)
    {
        var listCurrentImages = await docker.ListCurrentImages();
        var output = listCurrentImages.Select(
            X => new GetCurrentImageViewModel(
                X.Id, X.Image, X.Command, X.Created, X.Status, X.Ports, X.Size
            )
        ).ToList();

        return output;
    }
}
