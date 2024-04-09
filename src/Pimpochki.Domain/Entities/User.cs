
using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Domain.Entities
{
    public class User:EntityBase
    {
        public string UserName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int? RoleId { get; set; }

        public Role Role { get; set; } = null!;

        public ICollection<Order> Orders { get; } = new List<Order>();
    }
}