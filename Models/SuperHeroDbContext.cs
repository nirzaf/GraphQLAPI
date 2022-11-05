using Microsoft.EntityFrameworkCore;

namespace GraphQLAPI.Models;

public class SuperHeroDbContext : DbContext
{
    public SuperHeroDbContext(DbContextOptions<SuperHeroDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Generate three Guids and place them in an array
        var ids = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

        // Apply configuration for the three contexts in our application
        // This will create the demo data for our GraphQL endpoint.
        modelBuilder.ApplyConfiguration(new SuperheroContextConfiguration(ids));
        modelBuilder.ApplyConfiguration(new SuperpowerContextConfiguration(ids));
        modelBuilder.ApplyConfiguration(new MovieContextConfiguration(ids));
    }

    // Add the DbSets for each of our models we would like at our database
    public DbSet<Superhero> Superheroes { get; set; }
    public DbSet<Superpower> Superpowers { get; set; }
    public DbSet<Movie> Movies { get; set; }
}