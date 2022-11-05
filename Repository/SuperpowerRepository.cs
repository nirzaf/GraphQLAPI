using GraphQLAPI.IRepository;
using GraphQLAPI.Models;

namespace GraphQLAPI.Repository;

public class SuperpowerRepository : ISuperPowerRepository
{
    private readonly SuperHeroDbContext _dbContext;


    public SuperpowerRepository(SuperHeroDbContext dbContext)
    {
        _dbContext = dbContext;
    }
}