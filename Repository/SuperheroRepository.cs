using GraphQLAPI.IRepository;
using GraphQLAPI.Models;

using Microsoft.EntityFrameworkCore;

namespace GraphQLAPI.Repository;

public class SuperheroRepository : ISuperheroRepository
{
    private readonly SuperHeroDbContext _dbContext;

    public SuperheroRepository(SuperHeroDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Superhero> AddSuperhero(Superhero superhero)
    {
        await _dbContext.Superheroes.AddAsync(superhero);
        await _dbContext.SaveChangesAsync();
        return await Task.FromResult(superhero);
    }

    public async Task<Superhero?> GetSuperhero(Guid id)
    {
        var superhero = _dbContext.Superheroes.FirstOrDefault(x => x.Id == id);
        return await Task.FromResult(superhero);
    }

    public async Task<List<Superhero>> GetSuperheroes()
    {
        var superheroes = await _dbContext.Superheroes.ToListAsync();
        return superheroes;
    }
}