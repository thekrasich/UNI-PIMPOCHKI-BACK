using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Pimpochki.Application.Dtos
{

    public class CreateOrderDto
    {
        public DateTime DateTime { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int Quantity { get; set; }

    }
}