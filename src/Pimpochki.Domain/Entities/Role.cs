using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Domain.Entities
{
    public class Role:EntityBase
    {
        public string UserRole { get; set; }

        public ICollection<User> Users { get; } = new List<User>();
    }
}