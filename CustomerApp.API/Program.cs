using CustomerApp.API.Extensions;
using CustomerApp.API.Middlewares;
using CustomerApp.Repository;
using CustomerApp.Repository.Interfaces;
using CustomerApp.Repository.Repositories;
using CustomerApp.Service.Interfaces;
using CustomerApp.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



// Memanggil Extension
builder.Services.ConfigureServices(builder.Configuration);

//register middleware


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//handle middlware
app.UseMiddleware<TransactionIdMiddleware>();
app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
