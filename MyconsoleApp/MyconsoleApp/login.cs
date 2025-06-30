using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    //this demonstrates encapsulation
    internal class login
    {
          //properties
        public string username;
        public string password;

        //methods
        public void validate()
        {
            if (username == "mphasis" || password == "India")
            {
                Console.WriteLine("valid user");
            }
            else
            {
                Console.WriteLine("invalid user");
            }      
        }
    }
}
