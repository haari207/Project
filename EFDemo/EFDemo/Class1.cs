using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    internal class Class1
    {

        b248dbEntities ob = new b248dbEntities();
        public void Demo1()
        {
            var res = from t in ob.Customers
                      select new {t.cname}
            ;

            //display query info + timings
            //log is delegate
            ob.Database.Log=Console.WriteLine;
            foreach(var item in res)
            {
                Console.WriteLine(item.cname);
            }
        }
        public void Demo2()
        {

            ////ob.Database.Log = Console.WriteLine;

            var res = from t in ob.Customers
                   select t;

            //var res = ob.Customers.Include(c=>c.orders);
            // res customer +child tables
            foreach (var item in res)
            {
                Console.WriteLine(item.cid + ":" + item.cname);
                foreach (var order in item.orders)
                {
                    Console.WriteLine(order.orderid + ":" + order.product + ":" + order.qty);
                }
                Console.WriteLine("===============");
            }
        }

    }
}
