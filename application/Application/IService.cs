namespace Application;

public interface IService<TInput, TView>
{
    public TView Handle(TInput input);
}
