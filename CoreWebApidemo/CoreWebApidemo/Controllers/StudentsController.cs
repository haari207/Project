using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        string[] mystudents =
        {
            "Hari","Sahana","Divya","Madhu","kavya"
        };

        [HttpGet]
        public string[] Getstudents()
        {
            return mystudents;
        }




    }
}
