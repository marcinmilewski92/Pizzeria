using Application.Persistence.Contracts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PF.PizzaManagement.Application;
using Pizzeria.Domain.Entities;
using Pizzeria.Persistence;
using Pizzeria.Persistence.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IPizzaRepository, PizzaRepository>();
builder.Services.AddScoped<IBaseIngredientRepository, BaseIngredientRepository>();
builder.Services.AddScoped<ISinglePizzaOrderRepository, SinglePizzaOrderRepository>();
builder.Services.AddScoped<IAdditionalIngredientRepository, AdditionalIngredientsRepository>();

builder.Services.ConfigureApplicationServices();





var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
