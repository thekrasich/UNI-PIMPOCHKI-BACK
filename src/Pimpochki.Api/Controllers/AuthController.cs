using Microsoft.AspNetCore.Mvc;
using Pimpochki.Application.ActionFilters;
using Pimpochki.Application.ActionFilters.AuthActionFilters;
using Pimpochki.Application.Dtos.AuthDtos;
using Pimpochki.Application.Dtos.UserDtos;
using Pimpochki.Application.Services.Auth.Abstractions;


namespace Pimpochki.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController: ControllerBase
{
    private readonly IAuthService _authService;
    
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [ModelStateFilter]
    [HttpPost("login")]
    public async Task Login([FromBody] LoginDto loginDto)
    {
        await _authService.Login(loginDto);
    }
    
    [ModelStateFilter]
    [TypeFilter(typeof(RegisterActionFilterAttribute))]
    [HttpPost("register")]
    public async Task Register([FromBody] CreateUserDto createUserDto)
    {
        await _authService.Register(createUserDto);
    }
    
}