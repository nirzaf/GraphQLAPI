using GraphQLAPI.Models;

namespace GraphQLAPI;

public class Query
{
   private readonly SuperHeroDbContext _context;

   public Query(SuperHeroDbContext context)
   {
      _context = context;
   }

   //Fetch the list of superHeros objects
   [HotChocolate.Data.UseFiltering]
   [UseSorting]
   [GraphQLName("Superheros")]
   public IQueryable<Superhero> GetSuperheroes() =>
      _context.Superheroes;
   
   //Fetch the list of superHeros by Superpower Id
   [HotChocolate.Data.UseFiltering]
   [UseSorting]
   [GraphQLName("SuperherosBySuperpowerId")]
   public IQueryable<Superhero> GetSuperheroesBySuperpowerId(Guid superpowerId) =>
      _context.Superheroes.Where(x => x.Id == superpowerId);

   [GraphQLName("GetMovieById")]
   public async Task<Movie> GetMovieById(Guid id)
   {
      return await _context.Movies.FindAsync(id);
   }
}
