using ExceptionHandler.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionHandler.Controllers
{
    public class BaseController : Controller
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void HandleExceptions(System.Action func)
        {
            try
            {
                func();
            }
            // catch and handle more specific exceptions
            catch (CustomBLLException ex)
            {
                log.Error(string.Format("Custom Error: {0}", ex.Exception));
            }
            // catch and handle last and general all exceptions
            catch (Exception ex)
            {
                log.Error(string.Format("Error: {0}", ex));
                // add loger to log error 
            }
        }
    }
}