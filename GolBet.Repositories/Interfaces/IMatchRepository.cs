// GolBet.Repositories/Interfaces/IMatchRepository.cs
using GolBet.Entities;
using GolBet.Entities.Enums;

namespace GolBet.Repositories.Interfaces;

public interface IMatchRepository : IGenericRepository<Match> //hereda de la interfaz generica
{
    Task<IEnumerable<Match>> GetAllWithTeamsAsync(MatchStatus? status = null, String ? search = null);
    Task<Match?> GetByIdWithDetailsAsync(int id);
}