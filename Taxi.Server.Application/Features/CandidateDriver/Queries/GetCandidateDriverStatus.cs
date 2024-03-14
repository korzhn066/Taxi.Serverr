using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Server.Application.Features.CandidateDriver.Queries
{
    public class GetCandidateDriverStatus : IRequest<string>
    {
        public string UserName { get; set; } = null!;
    }
}
