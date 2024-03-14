using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using Taxi.Server.Api.Dto;
using Taxi.Server.Api.Helpers;
using Taxi.Server.Domain.Interfaces.Services;
using Taxi.Server.Domain.Models;

namespace Taxi.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
    }
}
