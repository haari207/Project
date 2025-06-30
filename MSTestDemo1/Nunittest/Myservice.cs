using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunittest
{
    public interface Imath
    {
        string Add(int x, int y);
        public int Data { get; set; }
        public  event EventHandler Myevent;
    }
    //public class Myservice:Imath
    //{
    //    public string Add(int x, int y)
    //    {
    //        int c = x + y;
    //        return "the sum is" + c;
    //    }
    //}
}
