using System.ComponentModel.DataAnnotations;

namespace GraphQLAPI.Models;

public class UpdateMovieInput
{
    [Key]
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Instructor { get; set; }
    public DateTime ReleaseDate { get; set; }
}