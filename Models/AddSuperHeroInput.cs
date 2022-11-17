namespace GraphQLAPI.Models;

public class AddSuperHeroInput
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Height { get; set; }
}