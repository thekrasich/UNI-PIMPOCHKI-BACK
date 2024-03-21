

namespace Pimpochki.Application.Dtos.OrderDtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        
        public int ProductId { get; set; }

        public int UserId { get; set; }

        public int Quantity { get; set; }
    }
}