using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class employee
    {

        int a;
        string b;
        public int age
        {
            set
            {
                a = value;
            while(a< 0 || a> 120)
                {
                    Console.WriteLine("Reenter the age");
                    a=int.Parse(Console.ReadLine());
                   }
               
            }
            get
            {
                return a;
            }
        }
        public string empname
        {
            set
            {
                b = value;
                while (b.Length < 5 || !b.StartsWith("s")) 
                {
                    Console.WriteLine("Reenter the name");     
                    b = Console.ReadLine();
                }
                 
            }
            get
            {
                return b.ToUpper();
            }
        }
        private string c;

        public string address
        {
            get { return c; }
            set {
                
                c = value;
                while(c != "banglr" && c != "chennai" && c != "hyd")
                {
                    Console.WriteLine("Reenter the address");
                    c = Console.ReadLine();
                }
                }
        }
        public int id { get; set; }

    }
}
