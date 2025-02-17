using Microsoft.OpenApi.Models;
using Study_Strategy_Pattern.Context;
using Study_Strategy_Pattern.Strategies;
using Microsoft.AspNetCore.Mvc;

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

app.MapPost("/calculate-freight", ([FromQuery] decimal weight, [FromQuery] string carrier) =>
{
    IFreightStrategy strategy = carrier.ToLower() switch
    {
        "correios" => new CorreiosFreight(),
        "fedex" => new FedexFreight(),
        "dhl" => new DhlFreight(),
        _ => throw new ArgumentException("Invalid carrier")
    };

    var calculator = new FreightCalculator(strategy);
    return Results.Ok(new { Carrier = carrier, Cost = calculator.Calculate(weight) });
})
.WithTags("Freight")
.WithName("CalculateFreight")
.WithOpenApi();

app.Run();
