using MediatR;

namespace Taxi.Server.Application.Features.ApplicationUser.Queries
{
    public class GetApplicationUserOrders : IRequest<List<Domain.Entities.Order>>
    {
        public string UserName { get; set; } = null!;
        public int Page { get; set; }
        public int Count { get; set; }
    }
}
