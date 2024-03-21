
using System.ComponentModel.DataAnnotations;
using Pimpochki.Application.Dtos.AuthDtos;

namespace Pimpochki.Application.Dtos.UserDtos
{

    public class CreateUserDto: LoginDto
    {
        [Required, MaxLength(100)] 
        public string UserName { get; set; } = null!;
        
    }
}
