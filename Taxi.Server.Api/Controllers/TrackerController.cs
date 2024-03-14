using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Taxi.Server.Api.Helpers;
using Taxi.Server.Domain.Interfaces.Services;
using Taxi.Server.Domain.Models;

namespace Taxi.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Driver")]
    public class TrackerController : ControllerBase
    {
        private readonly ITrackerService _trackerService;

        public TrackerController(ITrackerService trackerService)
        {
            _trackerService = trackerService;
        }

        [HttpPost]
        [Route("ChangeGeolocation")]
        public async Task<IActionResult> ChangeGeolocation(Geolocation geolocation)
        {
            await _trackerService.ChangeGeolocation(AuthenticateHelper.GetUserName(HttpContext), geolocation);
        
            return NoContent();
        }
    }
}
