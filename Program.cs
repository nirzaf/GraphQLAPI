using GraphQLAPI;
using GraphQLAPI.IRepository;
using GraphQLAPI.Models;
using GraphQLAPI.Repository;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SuperHeroDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register custom services for the superheroes
builder.Services.AddScoped<ISuperheroRepository, SuperheroRepository>();
builder.Services.AddScoped<ISuperPowerRepository, SuperpowerRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.UseGraphQLVoyager();

app.Run();