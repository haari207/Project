using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class parentcls
    {
        public parentcls() { 
        Console.WriteLine("parent class constructor");
        }
        public parentcls(int a):this()
        {
            Console.WriteLine("parent class constructor with parameter");
        }
        public void hi()
        {
            Console.WriteLine("hi from parent class");
        }
    }
    class childcls : parentcls
    {
        public childcls():base(10) //calls parent class constructor
        {
            Console.WriteLine("child class constructor");
        }
        public childcls(int a):this()
        {
            Console.WriteLine("child class constructor with parameter");
        }

        public void hi()
        {
            Console.WriteLine("childhi from parent class");
            base.hi();//calls base class hi method
        }

    }
}
