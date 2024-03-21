

namespace Pimpochki.Application.Dtos.ProductDtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public double Price { get; set; }

        public int Quantity { get; set; }
        
    }
}