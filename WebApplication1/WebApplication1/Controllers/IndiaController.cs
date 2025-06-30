using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class IndiaController : Controller
    {
        // GET: India
        public String Index(string id)
        {
            return "The india method is called" + id;
        }
        [OutputCache]
        public String show()
        {
            return "date and time is " + DateTime.Now.ToString();
        }
    }
}