using System.ComponentModel.DataAnnotations;

namespace Pimpochki.Application.Dtos.AuthDtos;

public class LoginDto
{
    [Required, EmailAddress]
    public string Email { get; init; }
    
    [Required, MinLength(8), MaxLength(100)]
    public string Password { get; init; }
}