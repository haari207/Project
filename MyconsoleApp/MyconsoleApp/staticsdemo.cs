using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal  static class staticdemo
    {
        public static int x=100;
        public static void hi()
        {
            Console.WriteLine("hi");    
        }

        public static int age { get; set; } = 10;
        static staticdemo()
        {
            Console.WriteLine("Constructor called");
        }
    }
}
