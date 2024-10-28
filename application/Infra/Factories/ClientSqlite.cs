using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Factories;

public class ClientSqlite : DbContext
{
    public DbSet<User> Users {get; set;}

    public string DbPath {get;}

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Data Source=teste.sqlite");
}
