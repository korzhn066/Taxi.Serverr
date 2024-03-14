using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Server.Domain.Models;

namespace Taxi.Server.Domain.Interfaces.Services
{
    public interface IOrderService
    {
        Task<string> CreateOrder(string clientUsername, Geolocation startPotint, Geolocation endPoint, double price
            , string driverUsername = "");
    }
}
