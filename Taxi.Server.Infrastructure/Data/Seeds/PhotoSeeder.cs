using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Taxi.Server.Domain.Entities;

namespace Taxi.Server.Infrastructure.Data.Seeds
{
    internal static class PhotoSeeder
    {
        internal static void SeedPhotos(this ModelBuilder builder)
        {
            builder.Entity<Photo>()
                .HasData(
                    new Photo()
                    {
                        Id = 1,
                        FilePath = "1.jpg",
                        CandidateDriverId = 1
                    },
                    new Photo()
                    {
                        Id = 2,
                        FilePath = "1.jpg",
                        CandidateDriverId = 1
                    },
                    new Photo()
                    {
                        Id = 3,
                        FilePath = "1.jpg",
                        CandidateDriverId = 2
                    }
                );
        }
    }
}
