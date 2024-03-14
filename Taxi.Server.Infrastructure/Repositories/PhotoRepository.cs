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
    public class PhotoRepository : RepositoryBase<Photo>, IPhotoRepository
    {
        public PhotoRepository(DBContext context) : base(context)
        {
        }
    }
}
