using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class EFCIs
    {

        b248dbEntities ob = new b248dbEntities();
        public void Demo1()
        {
            var res = ob.getcust(100);
            foreach (var item in res)
            {
                Console.WriteLine(item.cid + ":" + item.cname);
            }
        }

        public void demo2()
        {
            //how to write sql queries
            //DQL QUERIES
            //SELECT
            var res = ob.Database.SqlQuery<Customer>("select * from customers where cid between 400 and 800");
            foreach (var item in res)
            {
                Console.WriteLine(item.cid + ":" + item.cname + ":" + item.caddress + ":" + item.cphone);
            }
        }

        public void demo3()
        {
            //DML COMMANDS GO FOR THIS METHOD
            var res = ob.Database.ExecuteSqlCommand("DELETE FROM CUSTOMERS WHERE CID=900");
            Console.WriteLine("TOTAL DELETED RECORDS ARE:" + res);

        }

        public void demo4()
        {
            //generic repository
            Customer c = new Customer();
            c.cid = 1000;
            c.cname = "Ram";
            c.caddress = "Bangalore";
            c.cphone = "934567890";
            c.DOB = DateTime.Now;
            Genrepo gr = new Genrepo();
            gr.Insert(c);


        }

        public void demo5()
        {
            Customer c2 = new Customer();

            c2.cid = 600;
            Genrepo gr = new Genrepo();
            gr.delete(c2);
        }

        public void demo6()
        {
            Customer c = new Customer();
            Genrepo gr = new Genrepo();
            var res = gr.Find<Customer>(c.cid = 1000);
            if (res != null)
            {
                Console.WriteLine("Customer found:" + res.cid + ":" + res.cname + ":" + res.caddress + ":" + res.cphone);
            }
            else
            {
                Console.WriteLine("Customer not found");
            }
        }
        public void demo7()
        {
            Genrepo gr = new Genrepo();
            var res = gr.Top3<Customer>(3);
            foreach (var item in res)
            {
                Console.WriteLine(item.cid + ":" + item.cname + ":" + item.caddress + ":" + item.cphone);
            }
        }
    }
}
