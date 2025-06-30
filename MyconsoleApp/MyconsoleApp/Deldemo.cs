using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class Deldemo
    {

        public delegate void mydel(int x);    //Declaration
        //public void even(int x)
        //{
        //    Console.WriteLine(x+ "Even called");
        //}
        public void odd(int x) { Console.WriteLine(x + "Odd Called"); }

        public void show(int i)
        {
            mydel ob;
            if (i % 2 == 0)
            {
                //method-1
                // ob = new mydel(even);     //Instantiation
                //method-2 directly pointing to method
                //ob = even;
                //method-3 even function can be given directly here without creating method(it is anonymous delegate)
                //ob = delegate (int x) { Console.WriteLine(x + "Even called"); };
                //method -4 by using lambda expression 
                ob = (x) => { Console.WriteLine(x + "Even called"); };                                                 

            }
            else
            {
                ob = new mydel(odd);
            }
            ob.Invoke(i);      //invocation
        }











    }
}
