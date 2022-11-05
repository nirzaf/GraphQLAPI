using GraphQLAPI.IRepository;
using GraphQLAPI.Models;

namespace GraphQLAPI.Repository;

public class MovieRepository : IMovieRepository
{
    private readonly SuperHeroDbContext _dbContext;

    public MovieRepository(SuperHeroDbContext dbContext)
    {
        _dbContext = dbContext;
    }
}