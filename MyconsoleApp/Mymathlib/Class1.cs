using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mymathlib
{
    public class mymathcls
    {
        
        public int c { get; set; }
        public void add(int a,int b)
        {
            c = a + b;
            Console.WriteLine("The sum is:" + c);
        }
        public void sub(int a, int b)
        {
            c = a - b;
            Console.WriteLine("The difference is:" + c);
        }
    }
}
