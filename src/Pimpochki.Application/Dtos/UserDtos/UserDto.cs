

namespace Pimpochki.Application.Dtos.UserDtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int RoleId { get; set; }

    }
}