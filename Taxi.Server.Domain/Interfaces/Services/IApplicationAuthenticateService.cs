using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Server.Domain.Models;

namespace Taxi.Server.Domain.Interfaces.Services
{
    public interface IApplicationAuthenticateService
    {
        string CreateJwtToken();
        Task<bool> LoginAsync(ApplicationUserLogin applicationUserLogin);
        Task<IdentityResult> RegisterAsync(ApplicationUserRegister applicationUserRegister);
    }
}
