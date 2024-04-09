
using Microsoft.AspNetCore.Mvc;
using Pimpochki.Application.ActionFilters.OrderActionFilters;
using Pimpochki.Application.Dtos.OrderDtos;
using Pimpochki.Application.Persistence.EntityServices;

namespace Pimpochki.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{orderId}")]
        [TypeFilter(typeof(OrderExistFilterAttribute))]
        public async Task<OrderDto> GetOrder([FromRoute] int orderId)
        {
            var order =  await _orderService.GetOrder(orderId);
            return order;
        }
    }
}
