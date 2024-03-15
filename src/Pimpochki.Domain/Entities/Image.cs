using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Domain.Entities
{
    public class Image:EntityBase
    {
        public string Url { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;
    }
}