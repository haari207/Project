using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Class1
    {
        public int custid {  get; set; }
        public string name { get; set; }


        public void method1()
        {
            Console.WriteLine("Method1called");
        }

        public void method2()
        {
            Console.WriteLine("Method2 called");
        }

        public void Add(int a,int b)
        {
            Console.WriteLine("The sum is:"+(a+b));
        }


        public void Sub(int a, int b)
        {
            Console.WriteLine("The sub  is:" + (a - b));
        }

    }
}
