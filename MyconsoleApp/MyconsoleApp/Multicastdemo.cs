using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class Multicastdemo
    {
        public delegate void multidel();
        delegate string mydelstr();
        mydelstr ob;

        delegate void mygendel<T>(T x,T y);


        public void swap<T>(T x, T y)
        {
            T c;
            c = x;
            x = y;
            y = c;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }


        public void m1()
        {
            Console.WriteLine("m1 called");
        }
        public void m2()
        {
            Console.WriteLine("m2 called");
        }
        public string mydbmethod()
        {
            Thread.Sleep(1000);
            return "name=Kavya age=21";
        }

        public void display()
        {
         //   multidel ob = m1;
         //   ob += m2; //it adds a function
         ////   ob-=m1;   it removes a functions
         //   ob.Invoke();
         multidel ob1, ob2, ob3;
            ob1 = m1;
            ob2 = m2;
            ob3 = ob1 + ob2;
            ob3.Invoke();

            
        }
        public void show()
        {
            //mydelstr ob =mydbmethod;
            //var res=ob.Invoke();
            //Console.WriteLine(res);
            ob=mydbmethod;
            ob.BeginInvoke(showoutput,null);
            m1();
        }
        
        //callback function
        public void showoutput(IAsyncResult ar)
        {
            var res = ob.EndInvoke(ar); //end invoke aborts the thread
            Console.WriteLine(res);
        }

        public void callgen()
        {
            mygendel<int> ob = swap;
            ob.Invoke(20, 10);
        }
    }
}
