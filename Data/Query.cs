using GraphQLAPI.Models;

namespace GraphQLAPI.Data;

public class Query
{
    public IQueryable<Superhero> GetSuperheros => new List<Superhero>().AsQueryable();
}