using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApidemo.Models;
using System.Linq.Dynamic.Core;
namespace WebApidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SPFController : ControllerBase
    {
        b248dbContext ob=new b248dbContext();
        //how filtering works

        [Route("filter")]
        [HttpGet]

        public List<Studentstbl> Index(string name)
        {
            var res=from t in ob.Studentstbls where t.Sname==name select t;
            return res.ToList();
        }

        [Route("sort")]
        [HttpGet]

        //how sorting works
        public List<Studentstbl> Sortmethod(String columnname)
        {
            //if (columnname == "Sname")
            //{
            //    var res = from t in ob.Studentstbls orderby t.Sname select t;
            //    return res.ToList();
            //}

            //if (columnname == "Age")
            //{
            //    var res = from t in ob.Studentstbls orderby t.Age select t;
            //    return res.ToList();
            //}
            //else
            //{
            //    var res= from t in ob.Studentstbls select t;
            //    return res.ToList();

            //}
            var filteredStudents=ob.Studentstbls.AsQueryable().OrderBy(columnname).ToList();
            return filteredStudents;

        }

        //how paging works
        [HttpGet]
        [Route("paging")]
        public IList<Studentstbl> searchrow(int pageno, int pageSize)
        {
            var item = ob.Studentstbls.Skip((pageno - 1 * pageSize)).Take(pageSize);
            return item.ToList();
        }

    }
}
