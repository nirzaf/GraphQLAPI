using System.ComponentModel.DataAnnotations;

namespace GraphQLAPI.Models;

public class Superhero
{
    [Key]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Please specify a name for the SuperHero")]
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Height { get; set; }
}