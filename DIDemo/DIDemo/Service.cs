using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{

     interface Imath
    {
        void Add(int a, int b);
    } 
    internal class Service : Imath
    {
        // this is the class contains business logic(dbmethods,filehandling)

        Guid g;
        public Service()
        {
            // Constructor logic if needed
            g=Guid.NewGuid();
        }
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine(g.ToString());

        }
    }
}
