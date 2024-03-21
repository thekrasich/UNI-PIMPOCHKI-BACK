using AutoMapper;
using Pimpochki.Application.Dtos.ImageDtos;
using Pimpochki.Application.Dtos.OrderDtos;
using Pimpochki.Application.Dtos.ProductDtos;
using Pimpochki.Application.Dtos.UserDtos;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Application.Profiles;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Product,ProductDto>();
        CreateMap<CreateProductDto, Product>();
        CreateMap<UpdateProductDto, Product>();
        CreateMap<Image, ImageDto>();
        CreateMap<Order,OrderDto>();
        CreateMap<User,UserDto>();
        
    }
}