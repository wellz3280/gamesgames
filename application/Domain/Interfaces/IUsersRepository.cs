using Domain.Entities;

namespace Domain.Interfaces;

public interface IUsersRepository
{
    public void Save(User user);

    public User GetUserById(int id);

    public void Update(User user);

    public void Delete(User user);

}
