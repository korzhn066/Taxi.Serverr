using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Server.Application.Features.Roles.Commands
{
    public class GiveRoleDriverById : IRequest<IdentityResult>
    {
        public string Id { get; set; } = null!;
    }
}
