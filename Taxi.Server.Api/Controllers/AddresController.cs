using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Taxi.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddresController : ControllerBase
    {
        [HttpGet]
        [Route("GetAddreses")]
        public async Task<List<Address>> GetAddreses()
        {
            await Task.Delay(1000);

            return new List<Address>() { 
                new Address()
                {
                    Name= "Каменногорская 18",
                    latitude=0,
                    longitude=0,
                },
                new Address()
                {
                    Name= "Курчатова 5",
                    latitude=0,
                    longitude=0,
                },
                new Address()
                {
                    Name= "Курчатова 10",
                    latitude=0,
                    longitude=0,
                }
            };
        }
    }

    public class Address
    {
        public string Name { get; set; } = null!;
        public float latitude { get; set; }
        public float longitude { get; set; }
    }
}
