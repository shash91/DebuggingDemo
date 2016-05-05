using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DebuggingDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int firstVal = 10;
            int secondVal = 0;
            int result = firstVal / secondVal;
           // ViewBag.Message = "Welcome to ASP.Net MVC";
            return View(result);
        }
    }
}