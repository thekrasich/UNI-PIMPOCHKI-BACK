using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pimpochki.Application.Dtos.UserDtos
{
    public class UpdateUserDto
    {
        [Required, MaxLength(100)] 
        public string UserName { get; set; } = null!;

        [Required, EmailAddress] 
        public string Email { get; set; } = null!;

        [Required, MinLength(8), MaxLength(100)]
        public string Password { get; set; } = null!;
    }
}