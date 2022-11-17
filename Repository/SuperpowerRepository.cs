using System.Reflection.Metadata.Ecma335;

using GraphQLAPI.IRepository;
using GraphQLAPI.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraphQLAPI.Repository;

public class SuperpowerRepository : ISuperPowerRepository
{
    private readonly SuperHeroDbContext _dbContext;
    
    public SuperpowerRepository(SuperHeroDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Superpower> GetSuperPowerByIdAsync(Guid id)
    {
        return (await _dbContext.Superpowers.FindAsync(id))!;
    }
    
    public async Task<List<Superpower>> GetSuperPowersAsync()
    {
        return await _dbContext.Superpowers.ToListAsync();
    }
    
    public async Task<Superpower> AddSuperPowerAsync(Superpower superpower)
    {
        await _dbContext.Superpowers.AddAsync(superpower);
        await _dbContext.SaveChangesAsync();
        return superpower;
    }
    
    public async Task<Superpower> UpdateSuperPowerAsync(Guid id, Superpower superpower)
    {
        var super = await _dbContext.Superpowers.FindAsync(id);
        if (super == null)
        {
            return null!;
        }
        
        super.SuperPower = superpower.SuperPower;
        super.Description = superpower.Description;
        
        await _dbContext.SaveChangesAsync();
        return super;
    }
    
    public async Task<bool> DeleteSuperPowerAsync(Guid id)
    {
        var superpower = await _dbContext.Superpowers.FindAsync(id);
        _dbContext.Superpowers.Remove(superpower!);
        var result = await _dbContext.SaveChangesAsync();
        return result > 0;
    }
    
    public async Task<bool> SuperPowerExistsAsync(Guid id)
    {
        return await _dbContext.Superpowers.AnyAsync(e => e.Id == id);
    }
}