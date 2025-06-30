using System.Data.Entity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApidemo.Models;

namespace WebApidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestingController : ControllerBase
    {  

        b248dbContext ob=new b248dbContext();

        [HttpDelete]
        [Route("del")]
        public int Delete(int id)
        {  
            var res=(from t in ob.Studentstbls where t.Stid == id select t).FirstOrDefault();           
            ob.Studentstbls.Remove(res);
            int i =ob.SaveChanges();
            return i;
        }

        [HttpDelete]
        [Route("delp")]
        public Studentstbl Deleterow(int id)
        {
            Studentstbl obj= new Studentstbl();
            var res = (from t in ob.Studentstbls where t.Stid == id select t).FirstOrDefault();
            ob.Studentstbls.Remove(res);
            int i = ob.SaveChanges();
            return res;
        }

        [HttpGet]
        [Route("sear")]
        public IActionResult Searchrow(int id)
        {
            var res = (from t in ob.Studentstbls where t.Stid == id select t).FirstOrDefault();
            if (res == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(res);
            }
        }

        [HttpGet]
        [Route("gen")]
        public ActionResult<Studentstbl> Searchrowgen(int id)
        {
            var res = (from t in ob.Studentstbls where t.Stid == id select t).FirstOrDefault();
            if (res == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(res);
            }

        }

       //public async Task<List<Studentstbl>> showall()
       // {
       //     var res= from t in ob.Studentstbls select t;
       //     return await res.ToListAsync();
       // }





    }
}
