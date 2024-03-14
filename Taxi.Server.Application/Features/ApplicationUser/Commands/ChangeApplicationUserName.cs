using MediatR;

namespace Taxi.Server.Application.Features.ApplicationUser.Commands
{
    public class ChangeApplicationUserName : IRequest
    {
        public string UserName { get; set; } = null!;
        public string Name { get; set;} = null!;
    }
}
