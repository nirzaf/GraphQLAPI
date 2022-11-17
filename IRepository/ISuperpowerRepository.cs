using GraphQLAPI.Models;

namespace GraphQLAPI.IRepository;

public interface ISuperPowerRepository
{
    Task<Superpower> GetSuperPowerByIdAsync(Guid id);
    Task<List<Superpower>> GetSuperPowersAsync();
    Task<Superpower> AddSuperPowerAsync(Superpower superPower);
    Task<Superpower> UpdateSuperPowerAsync(Guid id, Superpower superPower);
    Task<bool> DeleteSuperPowerAsync(Guid id);
    Task<bool> SuperPowerExistsAsync(Guid id);
}