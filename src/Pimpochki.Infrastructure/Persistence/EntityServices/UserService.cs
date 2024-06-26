﻿using AutoMapper;
using Pimpochki.Application.Dtos.UserDtos;
using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Application.Persistence.EntityServices;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Infrastructure.Persistence.EntityServices;

public class UserService:IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository,IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    public async Task<UserDto> GetUserByEmail(string email)
    {
        var user = await _userRepository.GetAsync(obj =>obj.Email == email);
        var userDto = _mapper.Map<UserDto>(user);

        return userDto;
    }

    public async Task<UserDto> GetUserById(int id)
    {
        var user = await _userRepository.GetAsync(obj =>obj.Id == id);
        var userDto = _mapper.Map<UserDto>(user);

        return userDto;
    }

    public async Task UpdateUserName(string userName, User user)
    {
        user.UserName = userName;
        // _userRepository.Update(user);
        await _userRepository.SaveChages();
    }

    public async Task GrandRole(User user, Role role)
    {
        user.RoleId = role.Id;
        // _userRepository.Update(user);
        await _userRepository.SaveChages();
    }
}