
using System.ComponentModel.DataAnnotations;


namespace Pimpochki.Application.Dtos.ImageDtos
{
    public class UpdateImageDto
    {
        [Required, Url] 
        public string Url { get; set; } = null!;
    }
}