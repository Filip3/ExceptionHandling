using ExceptionHandler.Contracts;
using ExceptionHandler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler.BLL
{
    public class HomeBLL : IHomeBLL
    {
        public void MethodThatThrowsAnError(bool testValue)
        {
            if (testValue)
            {
                throw new CustomBLLException(Exceptions.CustomExceptions.CustomError.ToString());
            }

            throw new Exception();
        }
    }
}
