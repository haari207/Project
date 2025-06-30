using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class Linqdemo
    {
        public void demo1()
        {
            string[] st = { "India", "USA", "UK", "Canada", "Australia", "swiz" };
            var res = from t in st
                      where t.StartsWith("s")
                      select t;

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        public void demo2()
        {
            int[] data = { 10, 11, 12, 13, 14, 15, };
            var res = from t in data
                      where t.IsEven()
                      select t;
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        public void demo3()
        {

            //query expression
            List<product> al = new List<product>
            {
                new product() { pid = 100, pname = "watch", price = 1000},
                new product() { pid = 200, pname = "tablet", price = 3000 },
                new product() { pid = 300, pname = "pen", price = 100 },
                new product() { pid = 400, pname = "mobile", price = 300},
                new product() { pid = 500, pname = "marker", price = 200 }

            };
            //var res = from t in al
            //              //where t.price > 220 orderby t.price descending
            //          where t.price > 200 && t.price<6000 
            //          select t;

            var res = from t in al
                      select new { productid = t.pid, productname = t.pname };
            foreach (var item in res)
            {
                Console.WriteLine($"{item.productid} {item.productname}");

            }
        }

        public void demo4()
        {
            //lamda expression 

            List<product> al = new List<product>
            {
                new product() { pid = 100, pname = "watch", price = 1000},
                new product() { pid = 200, pname = "tablet", price = 3000 },
                new product() { pid = 300, pname = "pen", price = 100 },
                new product() { pid = 400, pname = "mobile", price = 300},
                new product() { pid = 500, pname = "marker", price = 200 }

            };

            //var res = al.Where(t => t.price > 300);
            //partition : take skip takewhile skipwhile
            //var res = al.Take(3);  it shows first top 3 data
            //var res=al.Skip(3);  it skips first 3 data

            var res = al.TakeWhile(t => t.price != 100); //IT shows data till it finds 100
            //var res=al.SkipWhile(t => t.price != 100); //it skips data till it finds 100

            //supports chaining 

            //var res = al.Take(5).Where(t => t.price > 300).Skip(1);
            foreach (var item in res)
            {
                Console.WriteLine(item.pid + " " + item.pname + " " + item.price);
            }

        }

        public void demo5()

        {


          
            int[] a = { 10, 20, 30, 40, 50, 30,40};
            int[] b = { 40, 50, 60, 70, 80 };
            //var res = a.Except(b);
            //var res = a.Intersect(b);
            //var res = a.Union(b); //it do not show duplicate values
            //var res = a.Distinct();

            //quantifier operators

            //var res = al.Any(t => t.price > 300);
            //var res = al.All(t => t.price > 300);
            //var r = al.Find(t => t.pid == 100);
            //var res = al.Contains(r);
            //Console.WriteLine(res);

        }

        public void demo6()
        {
            //plinq
           
            List<product> al = new List<product>
            {
                new product() { pid = 100, pname = "watch", price = 1000},
                new product() { pid = 200, pname = "tablet", price = 3000 },
                new product() { pid = 300, pname = "pen", price = 100 },
                new product() { pid = 400, pname = "mobile", price = 300},
                new product() { pid = 500, pname = "marker", price = 200 }

            };

            //var res = from t in al.AsParallel()
            //          where t.price > 250
            //          select t;


            //eg for inumerable:collections,lists,arrays
            //iqueryable:if the user is working with the database
            // not inmemory working with permanent data

            var res = from t in al.AsQueryable()
                      where t.price > 250
                      select t;
            foreach (var item in res)
            {
                Console.WriteLine($"{item.pid} {item.pname} {item.price}");
            }
        }
    }
}
