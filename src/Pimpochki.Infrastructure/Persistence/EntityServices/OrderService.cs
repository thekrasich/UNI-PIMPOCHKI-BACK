using AutoMapper;
using Pimpochki.Application.Dtos.ImageDtos;
using Pimpochki.Application.Dtos.OrderDtos;
using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Application.Persistence.EntityServices;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Infrastructure.Persistence.EntityServices;

public class OrderService:IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }
    public async Task<OrderDto> GetOrder(int id)
    {
        var order = await _orderRepository.GetAsync(obj => obj.Id == id);
        var orderDto = _mapper.Map<OrderDto>(order);
        return orderDto;
    }
}