using Pimpochki.Application.Dtos.AuthDtos;
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
        // Create user
        throw new NotImplementedException();
    }

    public Task Login(LoginDto loginDto)
    {
        // check if user exist and if password correct ;
        throw new NotImplementedException();
    }
}