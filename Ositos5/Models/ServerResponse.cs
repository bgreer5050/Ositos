using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ositos5.Models
{
    public class ServerResponse
    {
        public string Message { get; set; }
        public string OperationMessage { get; set; }
        public string ErrorType { get; set; }
        public string ErrorMessage { get; set; }

    }
}