using CustomerApp.API.Extensions;
using CustomerApp.API.Middlewares;
using CustomerApp.Domain.Dto.Responses;
using CustomerApp.Domain.Exceptions;
using CustomerApp.Repository;
using CustomerApp.Repository.Interfaces;
using CustomerApp.Repository.Repositories;
using CustomerApp.Service.Interfaces;
using CustomerApp.Service.Services;
using DotNetEnv;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;



//load .env
Env.Load();


var builder = WebApplication.CreateBuilder(args);

//db config


//load connstring dari .env
var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");


//Load connstring dari appsetting
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//connect ke db dengan postgres
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));


// Add services to the container.

builder.Services.AddControllers()
//custom validation handler
    .ConfigureApiBehaviorOptions( options => {
        options.InvalidModelStateResponseFactory = context =>
        {
            // Mengambil semua pesan error dari ModelState
            var errors = context.ModelState.Values
                                .SelectMany(v => v.Errors)
                                .Select(e => e.ErrorMessage);

            var response = new CommonResponseWithValidationException();
            var transactionId = context.HttpContext.Items["TransactionId"]?.ToString();

            response.StatusCode =(int) StatusCodes.Status400BadRequest;
            response.Errors = errors;
            response.Message = "One or more validation errors occurred";
            response.TransactionId = transactionId;
            return new BadRequestObjectResult(response);

        };


});
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
