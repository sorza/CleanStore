using CleanStore.Infrastructure.SharedContext;
using CleanStore.Application.SharedContext;
using MediatR;
using CleanStore.Infrastructure.SharedContext.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "Server=localhost,1433;Database=cleanstore;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";

builder.Services.AddInfrastructure();
builder.Services.AddApplication();
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString, m => m.MigrationsAssembly("CleanStore.Api")));

var app = builder.Build();

app.MapPost("/v1/accounts", async (
    ISender sender,
    CleanStore.Application.AccountContext.UseCases.Create.Command command) =>
{
    var result = await sender.Send(command);
    return TypedResults.Created($"v1/accounts/{result.Value.Id}", result);
});

app.Run();
