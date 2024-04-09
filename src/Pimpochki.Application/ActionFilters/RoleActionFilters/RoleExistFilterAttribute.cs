using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Pimpochki.Application.Persistence.EntityRepositories;

namespace Pimpochki.Application.ActionFilters.RoleActionFilters;

public class RoleExistFilterAttribute(IRoleRepository roleRepository):ActionFilterAttribute
{
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        int id = (int)context.ActionArguments["roleId"];
        if (await roleRepository.GetAsync(role => role.Id == id) is null)
        {
            context.ModelState.AddModelError("Role", "Role does not exist.");
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