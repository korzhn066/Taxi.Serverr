using Taxi.Server.Domain.Entities;
using Taxi.Server.Domain.Interfaces.Repositories;
using Taxi.Server.Infrastructure.Data;
using Taxi.Server.Infrastructure.Repositories.Base;

namespace Taxi.Server.Infrastructure.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(DBContext context) : base(context)
        {
        }
    }
}
