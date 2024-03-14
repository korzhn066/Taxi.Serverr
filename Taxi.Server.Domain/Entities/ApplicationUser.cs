using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Server.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = null!;
        public float Rating { get; set; } = 5;
        public int NumberRatingChanges { get; set; } = 1;
        public CandidateDriver? CandidateDriver { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
