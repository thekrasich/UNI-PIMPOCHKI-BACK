using Pimpochki.Application.Dtos.UserDtos;
using Pimpochki.Domain.Entities;

namespace Pimpochki.Application.Persistence.EntityServices;

public interface IUserService
{
    Task<UserDto> GetUserByEmail(string email);

    Task<UserDto> GetUserById(int id);
    Task UpdateUserName(string userName,User user); 
    void GrandRole(User user,Role role);
    
    
    
}