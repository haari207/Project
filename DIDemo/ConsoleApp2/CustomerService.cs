using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    interface Icustomer
    {
        void Addcustomer(Customer c);
        void Displaycustomer(List<Customer> c);
    }
    internal class CustomerService : Icustomer
    {
        public void Addcustomer(Customer c)
        {
            using (b248dbEntities db = new b248dbEntities())
            {
                
                db.Customers.Add(c);
                int r= db.SaveChanges();
                Console.WriteLine("Total no of rows inserted is:"+r);
            }
        }

        public void Displaycustomer(List<Customer> c)
        {
            using (b248dbEntities db = new b248dbEntities())
            {
                var customers = db.Customers.ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine($"ID: {customer.cid}, Name: {customer.cname}, DOB: {customer.DOB}, Address: {customer.caddress}, Phone: {customer.cphone}, PAN:{customer.pan}");
                }
            }

        }

       
    }
}
