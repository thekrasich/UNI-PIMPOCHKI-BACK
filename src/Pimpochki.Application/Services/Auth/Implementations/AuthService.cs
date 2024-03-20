using Pimpochki.Application.Dtos.UserDtos;
using Pimpochki.Application.Services.Auth.Abstractions;

namespace Pimpochki.Application.Services.Auth.Implementations;

public class AuthService: IAuthService
{
    private readonly IHashService _hashService;

    public AuthService(IHashService hashService)
    {
        _hashService = hashService;
    }
    public Task Register(CreateUserDto createUserDto)
    {
        throw new NotImplementedException();
    }

    public Task Login()
    {
        throw new NotImplementedException();
    }
}