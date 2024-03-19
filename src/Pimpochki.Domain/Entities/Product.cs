using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Domain.Entities
{
    public class Product:EntityBase
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public double Price { get; set; }

        public int Quantity { get; set; }

        public ICollection<Image> Images { get; } = new List<Image>();

        public ICollection<Order> Orders { get;} = new List<Order>();

        
    }
}