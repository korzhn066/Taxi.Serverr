using MediatR;
using Taxi.Server.Application.Features.ApplicationUser.Queries;
using Taxi.Server.Domain.Interfaces.Repositories;

namespace Taxi.Server.Application.Features.ApplicationUser.QueryHandlers
{
    internal class GetApplicationUserOrdersHandler : IRequestHandler<GetApplicationUserOrders, List<Domain.Entities.Order>>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public GetApplicationUserOrdersHandler(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }

        public async Task<List<Domain.Entities.Order>> Handle(GetApplicationUserOrders request, CancellationToken cancellationToken)
        {
            return await _applicationUserRepository.GetOrdersByUserNameAsync(request.UserName, request.Page, request.Count);
        }
    }
}
