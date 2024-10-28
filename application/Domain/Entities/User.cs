namespace Domain.Entities;

using System.ComponentModel.DataAnnotations.Schema;

public class User : BaseEntity
{
    [Column("name")]
    public string Name {get; set;}

    [Column("last_name")]
    public string LastName {get; set;}

    public User(
        int? Id,
        string Name,
        string LastName
    ) {
        this.Id = Id;
        this.Name = Name;
        this.LastName = LastName;
    }

    public string GetFullName()
    {
        return $"{this.Name} {this.LastName}";
    }
}
