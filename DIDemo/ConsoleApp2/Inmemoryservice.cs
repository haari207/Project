using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Inmemoryservice : Icustomer
    {
        public void Addcustomer(Customer c)
        {

            using (b248dbEntities db = new b248dbEntities())
            {

                db.Customers.Add(c);
                int r = db.SaveChanges();
                Console.WriteLine("Total no of rows inserted is:" + r);
            }
        }

       

        public void Displaycustomer(List<Customer> c) 
        { 


            foreach(var customer in c)
            {
                Console.WriteLine($"ID: {customer.cid}, Name: {customer.cname}, DOB: {customer.DOB}, Address: {customer.caddress}, Phone: {customer.cphone}, PAN: {customer.pan}");
            }
        }
    }
}
