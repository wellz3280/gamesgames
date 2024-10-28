using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

class Author
{
    [Key]
    public int id {get; private set;}

    public string name {get; private set;}

    public string descripion {get; private set;}

    public Author(
        string name,
        string descripion
    ){
        this.name = name;
        this.descripion = descripion;
    }
}