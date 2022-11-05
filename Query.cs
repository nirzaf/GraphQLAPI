using GraphQLAPI.Models;

namespace GraphQLAPI;

public class Query
{
   //Fetch the list of superHeros objects
   // [UseProjection]
   // [UseFiltering]
   // [UseSorting]
   [GraphQLName("Superheros")]
   public IQueryable<Superhero> GetSuperheroes([Service] SuperHeroDbContext context) =>
      context.Superheroes;
}
