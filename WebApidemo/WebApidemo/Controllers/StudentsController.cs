using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApidemo.Models;
namespace WebApidemo.Controllers
{
     // [Route("api/[controller]")]
     [ApiController]
    public class StudentsController : ControllerBase
    {

        b248dbContext ob = new b248dbContext();

        string[] mystudents =
        {
            "Sahana","Divya","kavya","hari"
        };

        string[] countries =
        {
            "India","UK","USA"
        };


        [Route("st")]
        [HttpGet]
        public string[] Getstudents()
        {
            return mystudents;
        }

        [Route("coun")]
        [HttpGet]
        public string[] Getcountries()
        {
            return countries;
        }


        //[Produces("application/json")]
        [Route("student")]
        [HttpGet]
        public List<Studentstbl> getstudents()
        {
            var res = from t in ob.Studentstbls select t;
            return res.ToList();
        }


        [Route("studentbyid")]
        [HttpGet]
        public List<Studentstbl> getstudentsbyid(int id)
        {
            var res = from t in ob.Studentstbls 
                      where t.Stid==id select t;
            return res.ToList();
        }


        [Route("api/Addstudents")]
        [HttpPost]
        public string PostStudents([FromQuery] Studentstbl st)
        {
            ob.Studentstbls.Add(st);
            int c=ob.SaveChanges();
            return "Total Record inserted is:" + c;
        }

        [Route("api/DeleteStudents")]
        [HttpDelete]
        public String DeleteStudents(int id)
        {
            var res = ob.Studentstbls.FirstOrDefault(t => t.Stid == id);
            if (res != null)
            {
                ob.Remove(res);
                int c = ob.SaveChanges();
                return "Deleted record count: " + c;
            }
            return "Record not found.";
        }
        [Route("api/UpdateStudents")]
        [HttpPut]
        public string UpdateStudents(int id, [FromQuery] Studentstbl st)
        {
            var res = ob.Studentstbls.FirstOrDefault(t => t.Stid == id);
            if (res != null)
            {
                res.Sname = st.Sname;
                res.Age = st.Age;
                int c = ob.SaveChanges();
                return "Updated record count: " + c;
            }
            return "Record not found.";
        }

    }
}
