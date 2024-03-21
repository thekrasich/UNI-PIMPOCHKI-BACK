

namespace Pimpochki.Application.Dtos.ImageDtos
{
    public class ImageDto
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int ProductId { get; set; }
    }

}