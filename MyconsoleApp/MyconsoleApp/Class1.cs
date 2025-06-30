using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{

  
    internal class Class1
    {
        public delegate void comethod(string st);
        public delegate object comethod2();

        public void display()
        {
            string s = "hello world";
            object o = s;
            comethod ob = testing;
            comethod2 obj = testing1;

        }
        public string testing1()
        {
            return "";
        }
        public void testing(object st)
        {

        }




    }
}
