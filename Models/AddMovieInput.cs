using System.ComponentModel.DataAnnotations;

namespace GraphQLAPI.Models;

public class AddMovieInput
{
    [Required(ErrorMessage = "Please specify a title for the Movie")]
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Instructor { get; set; }
    public DateTime ReleaseDate { get; set; }
}