using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal interface Imath
    {
        void Add(int a, int b);
        void sub(int a, int b);
    }

    internal interface Imath2
    {
        void Add(int a, int b);
        void divide(int a, int b);
        void multiply(int a, int b);
    }
    class Mymath : Imath, Imath2
    {
         void Imath2.Add(int a, int b)
        {
           Console.WriteLine(a+b);
        }

         void Imath.Add(int a, int b)
        {
            Console.WriteLine(a  + b);
        }

        public void divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        public void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);   
        }
    }
}
