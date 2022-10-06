using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PF.PizzaManagement.Application;
using Pizzeria.Domain.Identity;
using Pizzeria.Persistence;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<PizzeriaDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("PizzeriaConnectionString")));

builder.Services.AddCors(o =>
{
    o.AddPolicy("CorsPolicy",
        builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});


builder.Services.ConfigurePersistenceServices(builder.Configuration);
builder.Services.ConfigureApplicationServices();
builder.Services.ConfigureServicesFromServices();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();



app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
