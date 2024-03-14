using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Server.Api.Helpers;
using Taxi.Server.Application.Features.ApplicationUser.Queries;
using Taxi.Server.Application.Models;

namespace Taxi.Server.Application.Features.ApplicationUser.QueryHandlers
{
    internal class GetApplicationUserInformationHandler : IRequestHandler<GetApplicationUserInformation, ApplicationUserInformation>
    {
        private readonly UserManager<Domain.Entities.ApplicationUser> _userManager;
        public GetApplicationUserInformationHandler(UserManager<Domain.Entities.ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ApplicationUserInformation> Handle(GetApplicationUserInformation request, CancellationToken cancellationToken)
        {
            var user = await UserManagerHelper.GetApplicationUserByNameAsync(_userManager, request.UserName);

            return new ApplicationUserInformation()
            {
                Name = user.Name,
                PhoneNumber = user.PhoneNumber,
                Rating = user.Rating
            };
        }
    }
}
