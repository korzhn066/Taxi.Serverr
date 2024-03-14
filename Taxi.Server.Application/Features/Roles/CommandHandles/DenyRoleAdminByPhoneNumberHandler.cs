using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Server.Application.Features.Roles.Commands;
using Taxi.Server.Domain.Interfaces.Repositories;

namespace Taxi.Server.Application.Features.Roles.CommandHandles
{
    internal class DenyRoleAdminByPhoneNumberHandler : IRequestHandler<DenyRoleAdminByPhoneNumber, IdentityResult>
    {
        private readonly IApplicationUserRepository _userRepository;
        private readonly UserManager<Domain.Entities.ApplicationUser> _userManager;

        public DenyRoleAdminByPhoneNumberHandler(
            IApplicationUserRepository userRepository,
            UserManager<Domain.Entities.ApplicationUser> userManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public async Task<IdentityResult> Handle(DenyRoleAdminByPhoneNumber request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetFirstAsync(u => u.PhoneNumber == request.PhoneNumber);

            if (user is null)
                throw new ArgumentNullException(nameof(user));

            return await _userManager.RemoveFromRoleAsync(user, "Admin");
        }
    }
}
