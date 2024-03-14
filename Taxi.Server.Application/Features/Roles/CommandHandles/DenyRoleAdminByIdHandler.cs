using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Server.Api.Helpers;
using Taxi.Server.Application.Features.Roles.Commands;

namespace Taxi.Server.Application.Features.Roles.CommandHandles
{
    internal class DenyRoleAdminByIdHandler : IRequestHandler<DenyRoleAdminById, IdentityResult>
    {
        private readonly UserManager<Domain.Entities.ApplicationUser> _userManager;

        public DenyRoleAdminByIdHandler(
            UserManager<Domain.Entities.ApplicationUser> userManager) 
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(DenyRoleAdminById request, CancellationToken cancellationToken)
        {
            var user = await UserManagerHelper.GetApplicationUserByIdAsync(_userManager, request.Id);

            return await _userManager.RemoveFromRoleAsync(user, "Admin");
        }
    }
}
