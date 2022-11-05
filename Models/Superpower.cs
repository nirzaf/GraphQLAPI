using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLAPI.Models;

public class Superpower
{
    [Key]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Please specify a name for the Superpower")]
    public string SuperPower { get; set; }
    public string? Description { get; set; }
    
    [ForeignKey("SuperHeroId")]
    public Guid SuperheroId { get; set; }
    public Superhero Superhero { get; set; }
}