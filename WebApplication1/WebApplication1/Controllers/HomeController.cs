using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public  String Index()
        {
            return "index method called";
        }
        //[HandleError(View = "Error")]
        public ActionResult welcome()
        {
            throw new Exception("This is a test exception");
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}