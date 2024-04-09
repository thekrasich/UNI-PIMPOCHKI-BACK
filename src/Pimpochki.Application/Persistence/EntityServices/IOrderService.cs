using Pimpochki.Application.Dtos.OrderDtos;

namespace Pimpochki.Application.Persistence.EntityServices;

public interface IOrderService
{
    Task<OrderDto> GetOrder(int id);
}