using Pimpochki.Application.Dtos.UserDtos;

namespace Pimpochki.Application.Persistence.EntityServices;

public interface IAuthService
{
    Task Register(CreateUserDto createUserDto);
    Task Login();
}