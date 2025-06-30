using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class a {
       public void  Hi()
        {
            Console.WriteLine("Hi from class a");
        }

    }
    class b:a {
        public void first()
        {
            Console.WriteLine("first from class b");
        }

    }
    class c : b
    {
        public void Hello()
        {
            Console.WriteLine("Hello from class c");
        }
    }
}
