using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Pimpochki.Application.Dtos
{
    public class RoleDto
    {
        public string UserRole { get; set; } = null!;

    }

    public class CreateRoleDto
    {
         [Required, MaxLength(100)] 
         public string UserRole { get; set; } = null!;

    }
    public class UpdateRoleDto
    {
        [Required, MaxLength(100)] 
         public string UserRole { get; set; } = null!;

    }
}