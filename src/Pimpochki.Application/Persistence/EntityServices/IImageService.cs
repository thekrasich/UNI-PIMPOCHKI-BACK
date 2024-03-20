using Pimpochki.Application.Dtos.ImageDtos;

namespace Pimpochki.Application.Persistence.EntityServices;

public interface IImageService
{
    IEnumerable<ImageDto> GetAllImages(int id);
}