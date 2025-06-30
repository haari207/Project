using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    internal class Bestservice:Imath
    {// the better version of service class
        public void Add(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is { a + b}");
        }

    }
}
