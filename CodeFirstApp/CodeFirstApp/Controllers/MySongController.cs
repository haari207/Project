using CodeFirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApp.Controllers
{
    public class MySongController : Controller
    {
        SongContext s;
        //the instance is retrieved from context file using di
        public MySongController(SongContext s)
        {
            this.s = s;
        }

        public IActionResult Index()
        {
            var res= s.Songs.ToList();
            return View(res);
        }
    }
}
