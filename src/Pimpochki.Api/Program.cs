using Microsoft.OpenApi.Models;
using Pimpochki.Application;
using Pimpochki.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddInfrastructure(builder.Configuration);
    builder.Services.AddApplication(builder.Configuration);
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo() { Title = "My API", Version = "v1" });
        c.EnableAnnotations();
    });
}
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

{
    app.UseHttpsRedirection();
    app.MapControllers();
}

app.Run();

