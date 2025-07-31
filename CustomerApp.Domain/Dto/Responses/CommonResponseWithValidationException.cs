using CustomerApp.API.Dto.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Dto.Responses
{
    public class CommonResponseWithValidationException : CommonResponse
    {
        public Object Errors { get; set; }
    }
}
