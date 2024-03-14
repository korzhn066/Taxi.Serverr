﻿using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Server.Application.Features.Roles.Commands
{
    public class DenyRoleAdminByPhoneNumber : IRequest<IdentityResult>
    {
        public string PhoneNumber { get; set; } = null!;
    }
}
