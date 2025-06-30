using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classLib;
namespace WindowsFormsApp2
{

    internal class DICLass : Icustomer
    {
        public DICLass(Customer customer)
        {
            Class1 ob = new Class1();
            ob.Add(customer);
        }

        public void show()
        {

            Class1 ob = new Class1();
            List<Customer> customers = ob.display();
            if (customers.Count > 0)
            {
                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.CustomerId},{customer.CustName},{customer.CustomerType} {customer.Email}{customer.Age}{customer.Mobile}");
                }
            }
            else
            {
                Console.WriteLine("No customers found.");
            }
        }
    }
}
