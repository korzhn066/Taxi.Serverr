using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Server.Application.Models;

namespace Taxi.Server.Application.Features.CandidateDriver.Queries
{
    public class GetAllCandidates : IRequest<List<CandidateDriverInformation>>
    {
        public int Page { get; set; }
        public int Count { get; set; }
    }
}
