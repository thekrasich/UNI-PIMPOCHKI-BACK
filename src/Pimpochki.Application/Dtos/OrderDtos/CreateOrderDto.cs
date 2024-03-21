
using System.ComponentModel.DataAnnotations;


namespace Pimpochki.Application.Dtos.OrderDtos
{

    public class CreateOrderDto
    {
        public DateTime DateTime { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int Quantity { get; set; }

    }
}