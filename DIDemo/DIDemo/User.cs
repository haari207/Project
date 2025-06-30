using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
   

    internal class User
    {
        Imath m;

        // this is a class which consumes service class
        // here we call add method
        // Service ob = new Service();
        public User(Imath i) // i need to pass instance for i variable 
        {
            m = i;
        }
        //public Imath Myserviceinstance { get; set; }
        public void show()
        {
            m.Add(10, 20);             
        }




    }
}
