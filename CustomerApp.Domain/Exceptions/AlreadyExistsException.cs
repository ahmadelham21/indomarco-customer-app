using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Exceptions
{
    public class AlreadyExistsException : Exception
    {

        public AlreadyExistsException(string message) : base(message) { }
        public AlreadyExistsException(string entityName, string id)
         : base($"'{entityName}' with customerCode '{id}' Already Exist.") { }
    }
}
