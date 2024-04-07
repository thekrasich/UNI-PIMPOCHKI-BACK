using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Pimpochki.Application.Persistence.EntityRepositories;

namespace Pimpochki.Application.ActionFilters.UserActionFilters;

public class UserExistByEmailFilterAttribute(IUserRepository userRepository):ActionFilterAttribute
{
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        string? email = context.ActionArguments["email"].ToString();
        if (await userRepository.GetAsync(user => user.Email == email) is null)
        {
            context.ModelState.AddModelError("User", "User does not exist.");
            ValidationProblemDetails details = new ValidationProblemDetails(context.ModelState)
            {
                Status = HttpStatusCode.NotFound as int?
            };
            context.Result = new NotFoundObjectResult(details);
            return;
        }
        await next();
    }
}