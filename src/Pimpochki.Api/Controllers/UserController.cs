
using Microsoft.AspNetCore.Mvc;
using Pimpochki.Application.ActionFilters.UserActionFilters;
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
        [TypeFilter(typeof(UserExistByEmailFilterAttribute))]
        public async Task<UserDto> GetUserByEmail([FromRoute]string email)
        {
            var user = await _userService.GetUserByEmail(email);
            return user;
        }

        [HttpGet("{userId}")]
        [TypeFilter(typeof(UserExistByIdFilterAttribute))]
        public async Task<UserDto> GetUserById([FromRoute] int userId)
        {
            var user = await _userService.GetUserById(userId);
            return user;
        }

        [HttpPatch]
        public async Task UpdateName(string userName,int userId)
        {
            var user = await _userRepository.GetAsync(obj => obj.Id == userId);
            await _userService.UpdateUserName(userName, user);
        }

        [HttpPatch("{userId}/grand/{roleId}")]//?
        public async Task RoleGrant([FromRoute]int userId,[FromRoute]int roleId)
        {
            var user = await _userRepository.GetAsync(obj => obj.Id == userId);
            var role = await _roleRepository.GetAsync(obj => obj.Id == roleId);

            await _userService.GrandRole(user,role);
        }

    }
}
