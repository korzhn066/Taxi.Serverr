using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Server.Infrastructure.Data.Seeds
{
    internal static class IdentityRoleSeeder
    {
        internal static void SeedIdentityRoles(this ModelBuilder builder)
        {
            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole()
                    {
                        Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                        Name = "Client",
                        NormalizedName = "CLIENT",
                    },
                    new IdentityRole()
                    {
                        Id = "9e445865-a24d-4543-a6c6-9443d048cdb9",
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                    },
                    new IdentityRole()
                    {
                        Id = "0e445865-a24d-4543-a6c6-9443d048cdb9",
                        Name = "Driver",
                        NormalizedName = "DRIVER",
                    }
                );
        }
    }
}
