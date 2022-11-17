using System.Net;

using GraphQLAPI.IRepository;
using GraphQLAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace GraphQLAPI.Controllers;

public class SuperpowerController : Controller
{
    private readonly ISuperPowerRepository _superpowerRepository;

    public SuperpowerController(ISuperPowerRepository superpowerRespository)
    {
        _superpowerRepository = superpowerRespository;
    }

    [HttpGet]
    [Route("api/superpowers")]
    public async Task<IActionResult> GetSuperpowers()
    {
        var superpowers = await _superpowerRepository.GetSuperPowersAsync();
        return Ok(superpowers);
    }
    
    [HttpGet]
    [Route("api/superpowers/{id}")]
    public async Task<IActionResult> GetSuperpowerById(Guid id)
    {
        var superpower = await _superpowerRepository.GetSuperPowerByIdAsync(id);
        return Ok(superpower);
    }
    
    [HttpPost]
    [Route("api/superpowers")]
    public async Task<IActionResult> AddSuperpower([FromBody] Superpower superpower)
    {
        await _superpowerRepository.AddSuperPowerAsync(superpower);
        return Ok();
    }

    [HttpPut]
    [Route("api/superpowers/{id}")]
    public async Task<IActionResult> UpdateSuperpower(Guid id, [FromBody] Superpower superpower)
    {
        await _superpowerRepository.UpdateSuperPowerAsync(id, superpower);
        return Ok();
    }
    
    [HttpDelete]
    [Route("api/superpowers/{id}")]
    public async Task<IActionResult> DeleteSuperpower(Guid id)
    {
        await _superpowerRepository.DeleteSuperPowerAsync(id);
        return Ok();
    }
    
    [HttpGet]
    [Route("api/superpowers/isSuperPowerExists/{id}")]
    public async Task<IActionResult> IsSuperPowerExists(Guid id)
    {
        var isSuperPowerExists = await _superpowerRepository.SuperPowerExistsAsync(id);
        return Ok(isSuperPowerExists);
    }
    
}