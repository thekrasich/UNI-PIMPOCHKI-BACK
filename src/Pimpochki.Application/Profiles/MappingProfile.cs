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
        CreateMap<UpsertProductDto, Product>().ReverseMap();
        CreateMap<Image, ImageDto>();
        CreateMap<Order,OrderDto>();
        CreateMap<User,UserDto>();
        CreateMap<CreateUserDto, User>();

    }
}