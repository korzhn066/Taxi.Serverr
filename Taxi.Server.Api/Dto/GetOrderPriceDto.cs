using Taxi.Server.Domain.Models;

namespace Taxi.Server.Api.Dto
{
    public class GetOrderPriceDto
    {
        public Geolocation StartPoint { get; set; } = null!;
        public Geolocation EndPoint { get; set; } = null!;
    }
}
