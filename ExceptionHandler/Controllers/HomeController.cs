using ExceptionHandler.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionHandler.Controllers
{
    public class HomeController : BaseController
    {
        private IHomeBLL _homeBLL;
        public HomeController(IHomeBLL homeBLL)
        {
            _homeBLL = homeBLL;
        }

        public ActionResult Index()
        {
            HandleExceptions(() =>
            {
                _homeBLL.MethodThatThrowsAnError(true);
            });

            return View();
        }

        public ActionResult About()
        {

            HandleExceptions(() =>
            {
                _homeBLL.MethodThatThrowsAnError(false);
            });

            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}