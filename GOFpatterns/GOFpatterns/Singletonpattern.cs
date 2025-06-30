using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//scenario:1. shared database connections
//          2. any configuration which is common for all the users
//how to create singleton
//1.make the class is sealed
//2.make the class constructor is private
//3.create a static method which will return the instance of the class
namespace GOFpatterns
{
    internal sealed class Singletonpattern
    {
        // how to create  only single object,irrespective of no of users
        private Singletonpattern()
        {
            // constructor is private
        }
        static Singletonpattern s = null;
        public static Singletonpattern getinstance
        {
            get
            {
                if (s == null)
                {
                    s = new Singletonpattern();

                    return s;
                }
                else
                {
                    return s;
                }

            }
        }
        public void method()
        {
            Console.WriteLine("Singleton pattern");
        }



    }



    
}
