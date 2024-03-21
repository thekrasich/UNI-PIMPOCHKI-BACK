
using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Domain.Entities
{
    public class Role:EntityBase
    {
        public string UserRole { get; set; } = null!;

        public ICollection<User> Users { get; } = new List<User>();
    }
}