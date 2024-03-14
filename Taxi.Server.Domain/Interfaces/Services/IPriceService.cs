using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Server.Domain.Interfaces.Services
{
    internal interface IPriceService
    {
        Task<double> GetPrice();
    }
}
