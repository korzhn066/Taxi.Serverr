using Taxi.Server.Domain.Interfaces.Services;
using Taxi.Server.Domain.Models;

namespace Taxi.Server.Application.Services
{
    public class TrackerService : ITrackerService
    {
        private readonly Dictionary<string, Geolocation> _drivers;
        public TrackerService() 
        {
            _drivers = new Dictionary<string, Geolocation>();
        }
        public async Task ChangeGeolocation(string username, Geolocation geolocation)
        {
            await Task.Delay(0);

            _drivers.Add(username, geolocation);
        }

        public async Task<string> GetNearestDriverExluding(List<string> driverUsernames, Geolocation geolocation)
        {
            await Task.Delay(0);

            var result = "";
            var distance = 0d;

            foreach (var driver in _drivers)
            {
                if (result == "")
                {
                    result = driver.Key;
                    distance = GetDistance(geolocation, driver.Value);
                }else
                {
                    var newDistance = GetDistance(geolocation, driver.Value);
                    
                    if (newDistance < distance && !driverUsernames.Contains(driver.Key))
                    {
                        result = driver.Key;
                        distance = newDistance;
                    }
                }
            }

            return result;
        }

        public Task<List<string>> GetNearestDrivers(int count, Geolocation geolocation)
        {
            throw new NotImplementedException();
        }

        private static double GetDistance(Geolocation start, Geolocation end)
        {
            return Math.Sqrt((start.Latitude - end.Latitude) * (start.Latitude - end.Latitude) +
                (start.Longitude - end.Longitude) * (start.Longitude - end.Longitude));
        }

        public async Task EndWork(string username)
        {
            await Task.Delay(0);

            _drivers.Remove(username);
        }
    }
}
