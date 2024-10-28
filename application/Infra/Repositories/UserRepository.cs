namespace Infra.Repositories;

using Domain.Entities;
using Domain.Error;
using Domain.Interfaces;
using Infra.Factories;

public class UserRepository(ClientSqlite _context): IUsersRepository
{
    public void Save(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public List<User> GetUsers()
    {
        return _context.Users.ToList();
    }

    public User GetUserById(int id)
    {
        var user = _context.Users.Find(id);

        if (user is null) {
            throw new Exception("user not foound");
        }

        return user;
    }

    public void Update(User user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();
    }

    public void Delete(User user)
    {
        _context.Users.Remove(user);
        _context.SaveChanges();
    }
}
