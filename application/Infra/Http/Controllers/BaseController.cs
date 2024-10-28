namespace Infra.Http.Controllers;

public abstract class BaseController<TInput, TView>
{
    public abstract TView Handle(TInput input);
}
