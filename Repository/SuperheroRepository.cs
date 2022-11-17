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

    public async Task<Superhero> UpdateSuperhero(Superhero superhero)
    {
        var superheroToUpdate = _dbContext.Superheroes.FirstOrDefault(x => x.Id == superhero.Id);
        if (superheroToUpdate is not null)
        {
            superheroToUpdate.Name = superhero.Name;
            superheroToUpdate.Description = superhero.Description;
            superheroToUpdate.Height = superhero.Height;

            // check if entity is modified
            if (_dbContext.Entry(superheroToUpdate).State == EntityState.Modified)
            {
                await _dbContext.SaveChangesAsync();
            }
            return  superheroToUpdate;
        }

        return superhero;
    }
}