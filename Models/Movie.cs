using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLAPI.Models;

public class Movie
{
    [Key]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Please specify a title for the Movie")]
    public string Title { get; set; }
    public string? Description { get; set; }
    public string? Instructor { get; set; }
    public DateTime ReleaseDate { get; set; }
    
    [ForeignKey("SuperHeroId")]
    public Guid SuperheroId { get; set; }
    
    public Superhero Superhero { get; set; }
}