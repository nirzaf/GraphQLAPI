using GraphQLAPI.IRepository;
using GraphQLAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace GraphQLAPI.Controllers;

public class SuperheroController : Controller
{
    private readonly ISuperheroRepository _superheroRepo;

    public SuperheroController(ISuperheroRepository superheroRepo)
    {
        _superheroRepo = superheroRepo;
    }

    [HttpGet]
    [Route("api/superheroes")]
    public async Task<IActionResult> GetSuperheroes()
    {
        var superheroes = await _superheroRepo.GetSuperheroes();
        return Ok(superheroes);
    }

    [HttpGet]
    [Route("api/superheroes/{id}")]
    public async Task<IActionResult> GetSuperhero(Guid id)
    {
        var superhero = await _superheroRepo.GetSuperhero(id);
        return Ok(superhero);
    }
    
    [HttpPost]
    [Route("api/superheroes")]
    public async Task<IActionResult> AddSuperhero([FromBody] Superhero superhero)
    {
        await _superheroRepo.AddSuperhero(superhero);
        return Ok();
    }
    
    [HttpPut]
    [Route("api/superheroes")]
    public async Task<IActionResult> UpdateSuperhero([FromBody] Superhero superhero)
    {
        var superHero = await _superheroRepo.UpdateSuperhero(superhero);
        
        
        await _superheroRepo.UpdateSuperhero(superhero);
        return Ok();
    }
}