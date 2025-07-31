using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Exceptions
{
    public  class NotFoundException :Exception
    {

        public NotFoundException(string message) : base(message) { }

        public NotFoundException() : base(
            
            "Data Not Found"
            ) { }

        
        public NotFoundException(string entityName, object id)
            : base($"'{entityName}' with ID '{id}' Not Found.") { }




       
    }
}
