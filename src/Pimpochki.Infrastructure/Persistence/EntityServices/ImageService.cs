using AutoMapper;
using Pimpochki.Application.Dtos.ImageDtos;
using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Application.Persistence.EntityServices;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Infrastructure.Persistence.EntityServices;

public class ImageService:IImageService
{
    private readonly IImageRepository _imageRepository;
    private readonly IMapper _mapper;
    public ImageService(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }
    public IEnumerable<ImageDto> GetAllImages(int id)
    {
        var images =  _imageRepository.GetAll(obj => obj.ProductId == id);
        var imageDto = _mapper.Map<IEnumerable<ImageDto>>(images);
        return imageDto;
    }
}