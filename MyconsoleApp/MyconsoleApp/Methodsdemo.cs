using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class Methodsdemo
    {
        public static void valuetype(ref int x)
        {
            x += 10;
            Console.WriteLine("Value of x inside method is:" + x);
        }

        public static void outputtype(int a, int b,out int x,out int y)
        {
            x = a + b;
            y=a* b;
           

        }
        public static void optionaltype(int a, int b=20)
        {
           Console.WriteLine( a+b);


        }
        public static void paramstype(params int[] a)
        {
            int sum = 0;
            foreach (var item in a)
            {
                sum += item;
                Console.WriteLine(item);
            }
            Console.WriteLine("The sum is:" + sum);
            Console.WriteLine("------------------------>");

        }


    }
}
