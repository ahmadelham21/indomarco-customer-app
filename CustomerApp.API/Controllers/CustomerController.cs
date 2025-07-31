using CustomerApp.API.Dto.Requests;
using CustomerApp.API.Dto.Responses;
using CustomerApp.Domain.Dto.Requests;
using CustomerApp.Domain.Dto.Responses;
using CustomerApp.Domain.Entities;
using CustomerApp.Repository.Interfaces;
using CustomerApp.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CustomerApp.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }


        [HttpPost("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer([FromBody]CreateCustomerRequest request) { 
            
            CommonResponse response = new CommonResponse();
            var transactionId = HttpContext.Items["TransactionId"]?.ToString();


            Customer customer = new Customer();
            customer.CustomerName = request.CustomerName;
            customer.CustomerAddress = request.CustomerAddress;
            customer.CustomerCode = request.CustomerCode;
            customer.CreatedBy = request.CreatedBy;
            customer.CreatedAt = DateTime.UtcNow;

            await _customerService.CreateCustomer(customer);

            response.Message = "Successfully Create Customer";
            response.StatusCode = (int) HttpStatusCode.OK;
            response.TransactionId = transactionId;

            return Ok(response);
        
        }

        [HttpGet("GetAllCustomer")]

        public async Task<IActionResult> GetAllCustomer() {
            CommonResponseGetData<IEnumerable<Customer>> response = new CommonResponseGetData<IEnumerable<Customer>>();
            var transactionId = HttpContext.Items["TransactionId"]?.ToString();


            IEnumerable<Customer?>? data = await _customerService.GetAllCustomer();
            response.StatusCode = (int) HttpStatusCode.OK;
            response.Data = data;
            response.Message = "Successfully Get Data";
            response.TransactionId = transactionId;



            return Ok(response);
        }


        [HttpGet("GetCustomerById/{id}")]

        public async Task<IActionResult> GetCustomerById(int id) {
            CommonResponseGetData<Customer> response = new CommonResponseGetData<Customer>();
            var transactionId = HttpContext.Items["TransactionId"]?.ToString();

            Customer data = await _customerService.GetByIdCustomer(id);

            response.StatusCode= (int) HttpStatusCode.OK;
            response.TransactionId = transactionId;
            response.Data = data;
            response.Message = "Successfully Get Data";
            

            return Ok(response);
        
        }

        [HttpPut("UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomer([FromBody] UpdateCustomerRequest request)
        {

            CommonResponse response = new CommonResponse();
            var transactionId = HttpContext.Items["TransactionId"]?.ToString();

            Customer customer = new Customer();
            customer.CustomerName = request.CustomerName;
            customer.CustomerAddress = request.CustomerAddress;
            customer.CustomerCode = request.CustomerCode;
            

            await _customerService.UpdateCustomer(customer);

            response.Message = "Successfully Update Customer";
            response.StatusCode = (int)HttpStatusCode.OK;
            response.TransactionId= transactionId;

            return Ok(response);

        }


        [HttpDelete("DeleteCustomerById/{id}")]
        public async Task<IActionResult> DeleteCustomerById(int id) {

            CommonResponse response = new CommonResponse();

            var transactionId = HttpContext.Items["TransactionId"]?.ToString();

            await _customerService.DeleteCustomerById(id);

            response.Message = "Successfully Delete Customer";
            response.StatusCode = (int)HttpStatusCode.OK;
            response.TransactionId = transactionId;

            return Ok(response);

        }
    }
}
