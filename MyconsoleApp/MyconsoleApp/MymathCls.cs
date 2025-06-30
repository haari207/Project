using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class MymathCls
    {

        //public static void Add()
        //{

        //    int a = int.Parse(Console.ReadLine());
        //    int b = int.Parse(Console.ReadLine());
        //    int c = a + b;
        //    //Console.WriteLine("The sum of " +a+ "and " +b + " is " +c);
        //    //Console.WriteLine("The sum of {0} and {1} is {2}",a,b,c);
        //    Console.WriteLine($"The sum of {a} and {b} is {c}");
        //}

        public static void greatest()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"The greatest number is {a} and {b} than ");
            }
            else 
            {
                Console.WriteLine($"The greatest number is {b} than {a}");
            }
        }
        }
    }

