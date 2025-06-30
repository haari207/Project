using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Serviceuser
    {

        Icustomer c;
        public Serviceuser(Icustomer i)  
        {
            c = i;
        }

        public void show()
        {
            c.Addcustomer(new Customer());
            c.Displaycustomer(new List<Customer>());

        }
    }      
}
