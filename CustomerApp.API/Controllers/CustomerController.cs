using CustomerApp.API.Dto.Responses;
using CustomerApp.Repository.Interfaces;
using CustomerApp.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CustomerApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }


        [HttpGet]
        public CommonResponse<Object> TestingFromRepository() {
            
            CommonResponse<Object> response = new CommonResponse<Object>();
            Object data = _customerService.getData();
            response.Message = "Successfully Get Data";
            response.Data = data;
            response.StatusCode = (int)HttpStatusCode.OK;
            
            return response;
        }
    }
}
