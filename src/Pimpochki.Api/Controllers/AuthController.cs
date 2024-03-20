using Microsoft.AspNetCore.Mvc;
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
    
}