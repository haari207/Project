using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EFDemo
{
    internal class MyCustomers
    {

        //Model file

        b248dbEntities ob = new b248dbEntities();
        public void showcustomer()
        {
            var res = from t in ob.Customers
                      select t;

            foreach (var item in res)
            {
                Console.WriteLine($"{item.cid} {item.cname} {item.DOB}  {item.caddress} {item.cphone}");
            }
        }

        public void displaybyid()
        {
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            var res = (from t in ob.Customers
                       where t.cid == id
                       select t).FirstOrDefault();

            Console.WriteLine($"{res.cid} {res.cname} {res.DOB}  {res.caddress} {res.cphone}");

            //foreach  is not required if we use firstordefault
            //foreach( var item in res)
            //{
            //    Console.WriteLine($"{item.cid} {item.cname} {item.DOB}  {item.caddress} {item.cphone}");

            //}
        }
        public void Insertcustomer()
        {
            Customer c = new Customer()
            {
                cid = 900,
                cname = "Shreya",
                DOB = DateTime.Parse("1-1-2004"),
                caddress = "Pune",
                cphone = "9834567890"
            };
            ob.Customers.Add(c);
            var rows = ob.SaveChanges();//update to database
            Console.WriteLine("total rows inserted is:" + rows);
        }
        public void deletecustomer()
        {
            Console.WriteLine("enter id to delete");
            int id = int.Parse(Console.ReadLine());
            var res = (from t in ob.Customers
                       where t.cid == id
                       select t).FirstOrDefault();
            ob.Customers.Remove(res);
            var rows = ob.SaveChanges();
            Console.WriteLine("total rows deleted is:" + rows);

        }
        public void updatecustomer()
        {
            Console.WriteLine("enter id to update");
            int id = int.Parse(Console.ReadLine());
            var res = (from t in ob.Customers
                       where t.cid == id
                       select t).FirstOrDefault();
            res.caddress = "kerala";
            res.cphone = "9876543210";
            var rows = ob.SaveChanges();
            Console.WriteLine("total rows updated is:" + rows);

        }

        public void displayallorderscommon()
        {
            var res = from t in ob.Customers
                      join o in ob.orders on t.cid equals o.custid
                      select new { t.cname, o.orderid, o.product, o.price, o.qty };
            foreach (var item in res)
            {
                Console.WriteLine($"{item.cname} {item.orderid} {item.product} {item.price} {item.qty}");
            }
        }
        
        public void displaytop()
        {
            var res = (from t in ob.Customers
                       join o in ob.orders on t.cid equals o.custid
                       orderby o.price descending
                       select new {t.cname, o.orderid, o.product, o.price, o.qty }).Take(3);
            foreach (var item in res)
            {
                Console.WriteLine($"{item.orderid} {item.product} {item.price} {item.qty}");
            }
        }

        public void displaymax()
        {
            var res = (from o in ob.orders
                       group o by o.custid into g
                       select g.Max(x => x.price)).Max();
            Console.WriteLine("Maximum price is: " + res);

        }

        public void custnotordered()
        {
            var res = from t in ob.Customers
                      where !(from o in ob.orders select o.custid).Contains(t.cid)
                      select t;
            foreach (var item in res)
            {
                Console.WriteLine($"{item.cid} {item.cname} {item.DOB}  {item.caddress} {item.cphone}");
            }
        }
        public void displayorders()
        {
            var res= (from t in ob.Customers
                     join o in ob.orders on t.cid equals o.custid
                     where t.caddress=="Bangalore"
                     select new { t.cname, o.orderid, o.product, o.price, o.qty });
            foreach (var item in res)
            {
                Console.WriteLine($"{item.orderid} {item.product} {item.price} {item.qty}");
            }
        }
         
    }
}