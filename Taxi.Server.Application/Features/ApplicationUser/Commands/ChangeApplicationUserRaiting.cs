using MediatR;

namespace Taxi.Server.Application.Features.ApplicationUser.Commands
{
    public class ChangeApplicationUserRaiting : IRequest
    {
        public string UserName { get; set; } = null!;
        public int Raiting { get; set; }
    }
}
