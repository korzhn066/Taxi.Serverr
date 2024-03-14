using Taxi.Server.Domain.Entities;
using Taxi.Server.Domain.Interfaces.Repositories.Base;

namespace Taxi.Server.Domain.Interfaces.Repositories
{
    public interface IApplicationUserRepository : IRepositoryBase<ApplicationUser>
    {
        Task<List<Order>> GetOrdersByUserNameAsync(string userName, int page, int count, CancellationToken cancellationToken = default);
        Task<ApplicationUser?> GetUserWithCandidateDriverByUserNameAsync(string userName, CancellationToken cancellationToken = default);
    }
}
