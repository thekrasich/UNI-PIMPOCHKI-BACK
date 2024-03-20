using AutoMapper;
using Pimpochki.Application.Dtos.OrderDtos;
using Pimpochki.Application.Dtos.ProductDtos;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Application.Profiles;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Product,ProductDto>();
        CreateMap<CreateProductDto, Product>();
        CreateMap<UpdateProductDto, Product>();
        CreateMap<Order,OrderDto>();
    }
}