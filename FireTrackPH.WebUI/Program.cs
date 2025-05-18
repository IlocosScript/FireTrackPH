using FireTrackPH.Infrastructure;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddInfrastructure(configuration);
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
            });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("AllowOrigin");
app.Run();
