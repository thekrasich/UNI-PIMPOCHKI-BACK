using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Pimpochki.Application.Dtos.ProductDtos;
using Pimpochki.Application.Dtos.UserDtos;
using Pimpochki.Application.Persistence.EntityRepositories;

namespace Pimpochki.Application.ActionFilters.ProductActionFilters;

public class ProductUpsertFilterAttribute(IProductRepository productRepository):ActionFilterAttribute
{
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        CreateProductDto createProductDto = (CreateProductDto)context.ActionArguments["productDto"];

        if (await productRepository.GetAsync(product => product.Name == createProductDto.Name) is not null)
        {
            context.ModelState.AddModelError("Product", "Name already exist.");
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