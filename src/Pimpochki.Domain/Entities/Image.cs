
using Pimpochki.Domain.Entities.Common;

namespace Pimpochki.Domain.Entities
{
    public class Image:EntityBase
    {
        public string Url { get; set; } = null!;

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;
    }
}