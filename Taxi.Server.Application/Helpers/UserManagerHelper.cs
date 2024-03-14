﻿using Microsoft.AspNetCore.Identity;
using Taxi.Server.Domain.Entities;

namespace Taxi.Server.Api.Helpers
{
    public class UserManagerHelper
    {
        public static async Task<ApplicationUser> GetApplicationUserByNameAsync(UserManager<ApplicationUser> userManager, string userName)
        {
            var user = await userManager.FindByNameAsync(userName);

            if (user is null)
                throw new NullReferenceException();

            return user;
        }

        public static async Task<ApplicationUser> GetApplicationUserByIdAsync(UserManager<ApplicationUser> userManager, string userName)
        {
            var user = await userManager.FindByIdAsync(userName);

            if (user is null)
                throw new NullReferenceException();

            return user;
        }
    }
}
