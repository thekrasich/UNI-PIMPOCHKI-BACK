using AutoMapper;
using Pimpochki.Application.Dtos.AuthDtos;
using Pimpochki.Application.Dtos.UserDtos;
using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Application.Services.Auth.Abstractions;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Application.Services.Auth.Implementations;

public class AuthService: IAuthService
{
    private readonly IHashService _hashService;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public AuthService(IHashService hashService, IUserRepository userRepository,IMapper mapper)
    {
        _hashService = hashService;
        _userRepository = userRepository;
        _mapper = mapper;
    }
    public async Task Register(CreateUserDto createUserDto)
    {
        var createUser = _mapper.Map<User>(createUserDto);
        createUser.Password = _hashService.HashPassword(createUser.Password);
        createUser.RoleId = 1;
        await _userRepository.InsertAsync(createUser);
        await _userRepository.SaveChages();

    }

    public async Task Login(LoginDto loginDto)
    {
        var user = await _userRepository.GetAsync(obj => obj.Email == loginDto.Email);
        if (user == null)
        {
            throw new Exception(message:"user Not Found");
        }

        var isVerified = _hashService.VerifyPassword(user.Password, loginDto.Password);
        if (!isVerified)
        {
            throw new Exception(message:"not valid Password");
        }
        
    }
}