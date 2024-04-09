
using System.ComponentModel.DataAnnotations;


namespace Pimpochki.Application.Dtos.ImageDtos
{

    public class CreateImageDto
    {
         [Required, Url] 
        public string Url { get; set; } = null!;
    }

}