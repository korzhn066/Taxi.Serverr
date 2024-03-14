using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Server.Domain.Interfaces.Services;
using Taxi.Server.Domain.Models;

namespace Taxi.Server.Application.Services
{
    public class ORder
    {
        public Geolocation startPoint { get; set; } = null!;
        public Geolocation endPoint { get; set; } = null!;
        public double Price { get; set; }
        public string driverUsername { get; set; } = String.Empty;
    }

    public class OrderService : IOrderService
    {
        public Dictionary<string, ORder> _orders;

        public OrderService() 
        { 
            _orders = new Dictionary<string, ORder>();
        }

        public async Task<string> CreateOrder(string clientUsername, Geolocation startPotint, Geolocation endPoint
            , double price, string driverUsername = "")
        {
            await Task.Delay(0);

            _orders[clientUsername] = new ORder()
            {
                startPoint = startPotint,
                endPoint = endPoint,
                Price = price,
                driverUsername = driverUsername
            };

            return "";
        }

        public void DeleteOrder(string clientUsername)
        {
            _orders.Remove(clientUsername);
        }
    }
}
