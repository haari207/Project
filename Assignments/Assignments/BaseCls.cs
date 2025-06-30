using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class BaseCls
    {
        public BaseCls(int x) { 
         Console.WriteLine("base class :" +x);
        }
    }
    class derived:BaseCls
    {
        public derived(int x) :base(x)
        {
            Console.WriteLine("derived class:" +x);
        }
    }
}
