using Microsoft.EntityFrameworkCore;
using Taxi.Server.Domain.Entities;
using Taxi.Server.Domain.Interfaces.Repositories;
using Taxi.Server.Infrastructure.Data;
using Taxi.Server.Infrastructure.Repositories.Base;

namespace Taxi.Server.Infrastructure.Repositories
{
    public class ApplicationUserRepository : RepositoryBase<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(DBContext context) : base(context)
        {
        }

        public async Task<List<Order>> GetOrdersByUserNameAsync(string userName, int page, int count, CancellationToken cancellationToken = default)
        {
            var user = await Context.Users
                .Include(u => u.Orders)
                .FirstOrDefaultAsync(u => u.UserName == userName, cancellationToken);

            if (user is null) 
                throw new ArgumentNullException(nameof(user));

            return user.Orders.Skip(page * count).Take(count).ToList();
        }

        public async Task<ApplicationUser?> GetUserWithCandidateDriverByUserNameAsync(string userName, CancellationToken cancellationToken = default)
        {
            var user = await Context.Users
                .Include(u => u.CandidateDriver)
                .FirstOrDefaultAsync(u => u.UserName == userName, cancellationToken);

            return user;
        }
    }
}
