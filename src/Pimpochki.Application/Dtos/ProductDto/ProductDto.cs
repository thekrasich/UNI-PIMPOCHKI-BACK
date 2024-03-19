using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pimpochki.Application.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public double Price { get; set; }

        public int Quantity { get; set; }
        
    }

    public class CreateProductDto
    {
        [Required, MaxLength(100)] 
        public string Name { get; set; } = null!;

        [Required, MaxLength(500)] 
        public string Description { get; set; } = null!;

        [Required, Range(1, double.MaxValue)]
        public double Price { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int Quantity { get; set; }

    }
    public class UpdateProductDto
    {
        [Required, MaxLength(100)] 
        public string Name { get; set; } = null!;

        [Required, MaxLength(500)] 
        public string Description { get; set; } = null!;

        [Required, Range(1, double.MaxValue)]
        public double Price { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}