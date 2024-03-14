using MediatR;
using Taxi.Server.Application.Models;

namespace Taxi.Server.Application.Features.ApplicationUser.Queries
{
    public class GetApplicationUserInformation : IRequest<ApplicationUserInformation>
    {
        public string UserName { get; set; } = null!;
    }
}
