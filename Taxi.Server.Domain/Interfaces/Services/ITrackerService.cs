using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Server.Domain.Models;

namespace Taxi.Server.Domain.Interfaces.Services
{
    public interface ITrackerService
    {
        Task EndWork(string username);
        Task ChangeGeolocation(string username, Geolocation geolocation);
        Task<List<string>> GetNearestDrivers(int count, Geolocation geolocation);
        Task<string> GetNearestDriverExluding(List<string> driverUsernames, Geolocation geolocation);
    }
}
