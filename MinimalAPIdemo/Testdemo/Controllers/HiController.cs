using Microsoft.AspNetCore.Mvc;

namespace Testdemo.Controllers
{
    public class HiController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult India()
        {
            return View("hi");
        }

        public IActionResult First()
        {
            string[] st = { "", "" };
            return View(st);
        }

        public  RedirectToActionResult Second()
        {

            return RedirectToAction("Second");
        }
    }
}
