using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Server.Api.Helpers;
using Taxi.Server.Application.Features.ApplicationUser.Commands;
using Taxi.Server.Domain.Interfaces.Repositories;

namespace Taxi.Server.Application.Features.ApplicationUser.CommandHandlers
{
    internal class ChangeApplicationUserNameHandler : IRequestHandler<ChangeApplicationUserName>
    {
        private readonly UserManager<Domain.Entities.ApplicationUser> _userManager;
        private readonly IApplicationUserRepository _applicationUserRepository;

        public ChangeApplicationUserNameHandler(
            UserManager<Domain.Entities.ApplicationUser> userManager,
            IApplicationUserRepository applicationUserRepository)
        {
            _userManager = userManager;
            _applicationUserRepository = applicationUserRepository;
        }

        public async Task Handle(ChangeApplicationUserName request, CancellationToken cancellationToken)
        {
            var user = await UserManagerHelper.GetApplicationUserByNameAsync(_userManager, request.UserName);
        
            user.Name = request.Name;

            await _applicationUserRepository.SaveChangesAsync();
        }
    }
}
