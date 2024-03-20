using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Pimpochki.Application.Dtos
{
    public class ImageDto
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int ProductId { get; set; }
    }

}