using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler.Core
{
    public class CustomBLLException : System.Exception
    {
        // default contructor
        public CustomBLLException() : base()
        {

        }

        public CustomBLLException(string message) : base(message)
        {
            if (message == null)
                throw new ArgumentNullException("message");

            Exception = message;
        }

        public CustomBLLException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public string Exception { get; set; }
    }
}
