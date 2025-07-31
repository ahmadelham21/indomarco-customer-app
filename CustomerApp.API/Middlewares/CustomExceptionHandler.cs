using CustomerApp.API.Dto.Responses;
using CustomerApp.Domain.Dto.Responses;
using CustomerApp.Domain.Exceptions;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;




namespace CustomerApp.API.Middlewares
{
    public class CustomExceptionHandler
    {

        public static async Task HandleExceptionAsync(HttpContext context, Exception exception) {

            context.Response.ContentType = "application/json";
            var errorDetails = new CommonResponse();
            var transactionId = context.Items["TransactionId"]?.ToString();


            switch (exception)
            {
                

                case AlreadyExistsException alreadyExistsException:
                    errorDetails.TransactionId = transactionId;
                    errorDetails.StatusCode = (int) StatusCodes.Status409Conflict;
                    errorDetails.Message = alreadyExistsException.Message;
                    break;

                case NotFoundException notFoundException:
                    errorDetails.TransactionId = transactionId;
                    errorDetails.StatusCode = (int) StatusCodes.Status404NotFound;
                    errorDetails.Message = notFoundException.Message;
                    break;

          
                    await context.Response.WriteAsync(JsonSerializer.Serialize(errorDetails));
                    break;

                default:
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;         
                    errorDetails.StatusCode = (int) StatusCodes.Status500InternalServerError;
                    errorDetails.Message = "Internal Server Error";
                    break;
            }

            await context.Response.WriteAsync(JsonSerializer.Serialize(errorDetails));

        }
    }
}
