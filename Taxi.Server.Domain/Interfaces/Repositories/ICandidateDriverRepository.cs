using Taxi.Server.Domain.Entities;
using Taxi.Server.Domain.Interfaces.Repositories.Base;

namespace Taxi.Server.Domain.Interfaces.Repositories
{
    public interface ICandidateDriverRepository : IRepositoryBase<CandidateDriver>
    {
        Task<List<CandidateDriver>> GetCandidateDriverWithPhotosAsync(int page, int count, CancellationToken cancellationToken = default);
    }
}
