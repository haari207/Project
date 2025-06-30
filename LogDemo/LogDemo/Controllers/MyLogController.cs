using Microsoft.AspNetCore.Mvc;

namespace LogDemo.Controllers
{
    public class MyLogController : Controller
    {
        ILogger<MyLogController> l;
        public MyLogController(ILogger<MyLogController> logger)
        {
            l = logger;
        }

          
        public IActionResult Index()
        {
            l.LogError("Attempt to divide by zero"); //displays error
            l.LogWarning("Warning");  //meant for warning messages
            l.LogInformation("log info"); //general messages
            l.LogCritical("critical log"); //system level logs
            l.Log(LogLevel.Error, "sql is not working");

            return View();
        }

        public IActionResult show()
        {
            string actionName = RouteData.Values["action"]?.ToString();
            string controllerName = RouteData.Values["controller"]?.ToString();
            try
            {
                int a = 3; int b = 0;
                int c = a / b;
            }
            catch (Exception ex) {

                l.LogError(ex.Message,actionName,controllerName);
            }
            return View();

        }


    }
}
