using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Domain.Entities
{
    public class Order:EntityBase
    {
        public DateTime DateTime { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public int UserId { get; set; }

        public Product Product { get; set; } = null!;

        public User User { get; set; } = null!;
    }
}