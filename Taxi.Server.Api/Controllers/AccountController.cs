using AutoMapper.Configuration.Conventions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Taxi.Server.Api.Helpers;
using Taxi.Server.Application.Features.ApplicationUser.Commands;
using Taxi.Server.Application.Features.ApplicationUser.Queries;

namespace Taxi.Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetUserName")]
        public async Task<IActionResult> GetUserName()
        {
            var name = await _mediator.Send(new GetApplicationUserName() { 
                UserName = AuthenticateHelper.GetUserName(HttpContext) 
            });

            return Ok(name);
        }

        [HttpGet]
        [Route("GetUserOrders")]
        public async Task<IActionResult> GetUserOrders(int page, int count)
        {
            var orders = await _mediator.Send(new GetApplicationUserOrders()
            {
                Page = page,
                Count = count,
                UserName = AuthenticateHelper.GetUserName(HttpContext)
            });

            return Ok(orders);
        }

        [HttpGet]
        [Route("GetUserInformation")]
        public async Task<IActionResult> GetUserInformation()
        {
            var userInformation = await _mediator.Send(new GetApplicationUserInformation()
            {
                UserName = AuthenticateHelper.GetUserName(HttpContext)
            });

            return Ok(userInformation);
        }

        [HttpPatch]
        [Route("ChangeUserName")]
        public async Task<IActionResult> ChangeUserName(string name)
        {
            await _mediator.Send(new ChangeApplicationUserName() 
            { 
                Name = name,
                UserName = AuthenticateHelper.GetUserName(HttpContext)
            });

            return NoContent();
        }

        [HttpPatch]
        [Route("ChangeUserPhoneNumber")]
        public async Task<IActionResult> ChangeUserPhoneNumber(string phoneNumber)
        {
            await _mediator.Send(new ChangeApplicationUserPhoneNumber()
            {
                PhoneNumber = phoneNumber,
                UserName = AuthenticateHelper.GetUserName(HttpContext)
            });

            return NoContent();
        }

        [HttpPatch]
        [Route("ChangeUserRating")]
        public async Task<IActionResult> ChangeUserRating(int rating)
        {
            await _mediator.Send(new ChangeApplicationUserRaiting()
            {
                UserName = AuthenticateHelper.GetUserName(HttpContext),
                Raiting = rating,
            });

            return NoContent();
        }
    }
}
