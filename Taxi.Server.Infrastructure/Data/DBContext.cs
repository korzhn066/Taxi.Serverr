using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Taxi.Server.Domain.Entities;
using Taxi.Server.Infrastructure.Data.Seeds;

namespace Taxi.Server.Infrastructure.Data
{
    public class DBContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<CandidateDriver> CandidateDrivers { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DBContext(DbContextOptions options) : base(options) {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedIdentityRoles();
            builder.SeedApplicationUsers();  
            builder.SeedIdentityUserRoles();
            builder.SeedCandidateDrivers();
            builder.SeedOrders();
            builder.SeedPhotos();

            base.OnModelCreating(builder);
        }
    }
}
