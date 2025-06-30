using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    class c1
    {
        public void hi()
        {

            Console.WriteLine("hi called within namespace");
        }

    }
    internal class globalnamespace
    {

        public void display()
        {
#pragma warning disable
            int m;
#pragma warning restore

            c1 obj = new c1();
            obj.hi();
            global::c1 obj1 = new global::c1();
            obj1.hi();

        }



        public Tuple<int, string> getdata()
        {

            string name = "Anu";
            int age = 25;
            Tuple<int, string> t = new Tuple<int, string>(age, name);
            return t;

        }





    }

    static class myexcls
    {
        public  static bool IsEven(this int x)//this keyword represents extension method
        {
            return x % 2 == 0;

        }
        public static int Tointeger(this string s)
        {
            return int.Parse(s);
        }
        public static int add(this c1 c, int x, int y)
        {
          
          
            return  x+y;
        }
    }

  
}
class c1
{
    public void hi()
    {
       
        Console.WriteLine("hi called outside the namespace");
    }
}
