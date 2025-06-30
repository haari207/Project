using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApp.Controllers
{
    public class MYDIController : Controller
    {
        Imyinter obj;
        //public MYDIController(Imyinter m)
        //{
        //    obj = m;
        //}

        //[HttpGet]
        //public IActionResult Index([FromServices] Imyinter m)
        //{
        //    ViewData["res"] = m.Addnums(2, 3);
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Index(int t1, int t2)
        //{
        //    ViewBag.t1 = t1;
        //    ViewBag.t2 = t2;
        //    ViewBag.res = t1 + t2;
        //    return View();
        //}

        public IActionResult Index()
        {
            var services=this.HttpContext.RequestServices;
            var log = (Imyinter)services.GetService(typeof(Imyinter));
            ViewBag.res= log.Addnums(2,3);
            return View();
        }
    }
}
