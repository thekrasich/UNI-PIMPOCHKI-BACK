
using System.ComponentModel.DataAnnotations;


namespace Pimpochki.Application.Dtos.OrderDtos
{

    public class CreateOrderDto
    {
        public DateTime DateTime { get; set; } = DateTime.Now;

        [Required, Range(1, int.MaxValue)]
        public int Quantity { get; set; }

    }
}