using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler.Contracts
{
    public interface IHomeBLL
    {
        void MethodThatThrowsAnError(bool testValue);
    }
}
