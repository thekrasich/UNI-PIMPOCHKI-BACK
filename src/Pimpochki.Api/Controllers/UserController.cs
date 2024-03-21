using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pimpochki.Application.Dtos.UserDtos;
using Pimpochki.Application.Persistence.EntityRepositories;
using Pimpochki.Application.Persistence.EntityServices;

namespace Pimpochki.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        public UserController(IUserService userService,IUserRepository userRepository,IRoleRepository roleRepository)
        {
            _userService = userService;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }
        [HttpGet("email/{email}")]
        public async Task<UserDto> GetUserByEmail([FromRoute]string email)
        {
            var user = await _userService.GetUserByEmail(email);
            return user;
        }

        [HttpGet("{id}")]
        public async Task<UserDto> GetUserById([FromRoute] int id)
        {
            var user = await _userService.GetUserById(id);
            return user;
        }

        [HttpPatch]
        public async Task UpdateName(string userName,int id)
        {
            var user = await _userRepository.GetAsync(obj => obj.Id == id);
            await _userService.UpdateUserName(userName, user);
        }

        [HttpPatch("{userId}/grand/{roleId}")]
        public async Task RoleGrant([FromRoute]int userId,[FromRoute]int roleId)
        {
            var user = await _userRepository.GetAsync(obj => obj.Id == userId);
            var role = await _roleRepository.GetAsync(obj => obj.Id == roleId);

            await _userService.GrandRole(user,role);
        }

    }
}
