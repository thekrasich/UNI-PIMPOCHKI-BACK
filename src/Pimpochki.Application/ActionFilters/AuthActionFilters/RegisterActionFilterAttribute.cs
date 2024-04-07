using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Pimpochki.Application.Dtos.UserDtos;
using Pimpochki.Application.Persistence.EntityRepositories;

namespace Pimpochki.Application.ActionFilters.AuthActionFilters;

public class RegisterActionFilterAttribute(IUserRepository userRepository): ActionFilterAttribute
{
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        CreateUserDto createUserDto = (CreateUserDto)context.ActionArguments["createUserDto"];

        if (await userRepository.GetAsync(user => user.Email == createUserDto.Email) is not null)
        {
            context.ModelState.AddModelError("User", "Email already exist.");
            ValidationProblemDetails details = new ValidationProblemDetails(context.ModelState)
            {
                Status = HttpStatusCode.Conflict as int?
            };
            context.Result = new ConflictObjectResult(details);
            return;
        }

        await next();
    }
}