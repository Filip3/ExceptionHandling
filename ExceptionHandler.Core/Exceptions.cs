using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler.Core
{
    public class Exceptions
    {
        public enum CustomExceptions
        {
            [Description("A custom error has been thrown and caught.")]
            CustomError
        }
    }
}
