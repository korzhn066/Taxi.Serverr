using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Server.Domain.Entities;
using Taxi.Server.Domain.Interfaces.Repositories;
using Taxi.Server.Infrastructure.Data;
using Taxi.Server.Infrastructure.Repositories.Base;

namespace Taxi.Server.Infrastructure.Repositories
{
    public class CandidateDriverRepository : RepositoryBase<CandidateDriver>, ICandidateDriverRepository
    {
        public CandidateDriverRepository(DBContext context) : base(context)
        {
        }

        public async Task<List<CandidateDriver>> GetCandidateDriverWithPhotosAsync(int page, int count, CancellationToken cancellationToken = default)
        {
            return await Context.CandidateDrivers
                .Include(cd => cd.Photos)
                .Skip(page*count)
                .Take(count)
                .ToListAsync(cancellationToken);
        }
    }
}
