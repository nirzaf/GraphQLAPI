using GraphQLAPI.Models;

using static System.Globalization.CultureInfo;
using static System.Globalization.DateTimeStyles;

namespace GraphQLAPI;


public class Mutation
{

    [GraphQLName("AddSuperhero")]
    [UseDbContext(typeof(SuperHeroDbContext))]
    public async Task<Superhero> AddSuperHeroAsync(AddSuperHeroInput input, 
        [ScopedService] SuperHeroDbContext context, CancellationToken cancellationToken)
    {
        var superHero = new Superhero
        {
            //assign new Guid to Id
            Id = Guid.NewGuid(),
            Name = input.Name,
            Description = input.Description,
            Height = input.Height
        };

        context.Superheroes.Add(superHero);
        await context.SaveChangesAsync(cancellationToken);

        return superHero;
    }

    [GraphQLName("AddMovie")]
    [UseDbContext(typeof(SuperHeroDbContext))]
    public async Task<Movie> AddMovieAsync(AddMovieInput input, 
        [ScopedService] SuperHeroDbContext context, CancellationToken cancellationToken)
    {
        
        var movie = new Movie
        {
            //assign new Guid to Id
            Id = Guid.NewGuid(),
            Title = input.Title,
            Description = input.Description,
            ReleaseDate = input.ReleaseDate,
            Instructor = input.Instructor,
        };

        context.Movies.Add(movie);
        await context.SaveChangesAsync(cancellationToken);
        return movie;
    }
    
    [GraphQLName("UpdateMovie")]
    [UseDbContext(typeof(SuperHeroDbContext))]
    public async Task<Movie> UpdateMovieAsync(UpdateMovieInput input, 
        [ScopedService] SuperHeroDbContext context, CancellationToken cancellationToken)
    {
        var movie = await context.Movies.FindAsync(input.Id);
        if (movie == null)
        {
            throw new Exception("Movie not found");
        }

        movie.Title = !string.IsNullOrWhiteSpace(input.Title) ? input.Title! : movie.Title;
        
        movie.Description = !string.IsNullOrWhiteSpace(input.Description) ? input.Description! : movie.Description;
        
        //check if movie.ReleaseDate is in valid format, if not then assign the same source value
        movie.ReleaseDate = IsValidDate(input.ReleaseDate.ToString(InvariantCulture)) ? input.ReleaseDate : movie.ReleaseDate;

        movie.Instructor = !string.IsNullOrWhiteSpace(input.Instructor) ? input.Instructor : movie.Instructor;

        await context.SaveChangesAsync(cancellationToken);
        return movie;
    }
    
    public static bool IsValidDate(string date)
    {
        return DateTime.TryParseExact(date, new[] { "dd/MM/yyyy", "MM/dd/yyyy" }, InvariantCulture, None, out DateTime _);
    }
}

