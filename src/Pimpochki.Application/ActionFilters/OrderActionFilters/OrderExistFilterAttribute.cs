using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Pimpochki.Application.Persistence.EntityRepositories;

namespace Pimpochki.Application.ActionFilters.OrderActionFilters;

public class OrderExistFilterAttribute(IOrderRepository orderRepository):ActionFilterAttribute
{
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        int id = (int)context.ActionArguments["orderId"];
        if (await orderRepository.GetAsync(order => order.Id == id) is null)
        {
            context.ModelState.AddModelError("Order", "Order does not exist.");
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