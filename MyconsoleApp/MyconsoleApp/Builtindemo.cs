using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class Builtindemo
    {
        public void Add()
        {
            Console.WriteLine("Add called");
        }

        public void sub(int x)
        {
            Console.WriteLine("the value is" + x);
        }

        public string multiply(int x, int y)
        {
            return "the product is"+ x * y;
        }

        public double factorial()
        {
            return 0.5;
        }
        public void display()
        {
            Action ob = Add;
            ob.Invoke();
            Console.WriteLine("---------------------");
            Action<int> ob1 = sub;//with parameter
            ob1.Invoke(10);

            Console.WriteLine("---------------------");

            Func<int,int,string> ob2 = multiply;
            var res=ob2.Invoke(2, 3);
            Console.WriteLine(res);

            Func<double> res1 = factorial;
            var r=res1.Invoke();
            Console.WriteLine(r);
        }
    }
}
