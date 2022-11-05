using GraphQLAPI.IRepository;
using GraphQLAPI.Models;

namespace GraphQLAPI.Repository;

public class SuperheroRepository : ISuperheroRepository
{
    private readonly SuperHeroDbContext _dbContext;

    public SuperheroRepository(SuperHeroDbContext dbContext)
    {
        _dbContext = dbContext;
    }
}