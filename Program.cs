using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Freight Calculation API",
            Version = "v1",
            Description = "This API allows users to calculate freight costs using different strategies for various carriers (Correios, FedEx, and DHL).",
        });
    }
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Freight Calculation API v1");
            options.RoutePrefix = string.Empty;
        });
}

app.Run();
