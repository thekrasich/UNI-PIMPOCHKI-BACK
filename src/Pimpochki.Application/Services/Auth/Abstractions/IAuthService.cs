using Pimpochki.Application.Dtos.AuthDtos;
using Pimpochki.Application.Dtos.UserDtos;

namespace Pimpochki.Application.Services.Auth.Abstractions;

public interface IAuthService
{
    Task Register(CreateUserDto createUserDto);
    Task Login(LoginDto loginDto);
}