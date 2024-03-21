using Microsoft.AspNetCore.Mvc;
using Pimpochki.Application.Dtos.AuthDtos;
using Pimpochki.Application.Dtos.UserDtos;
using Pimpochki.Application.Services.Auth.Abstractions;
using Pimpochki.Application.Services.Auth.Implementations;

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

    [HttpPost("login")]
    public async Task Login([FromBody] LoginDto loginDto)
    {
        await _authService.Login(loginDto);
    }
    
    [HttpPost("register")]
    public async Task Register([FromBody] CreateUserDto createUserDto)
    {
        await _authService.Register(createUserDto);
    }
    
}