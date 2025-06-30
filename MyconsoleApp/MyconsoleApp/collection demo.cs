using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MyconsoleApp
{
    internal class collection_demo
    {
        public void arraylistdemo()
        {
            ArrayList al = new ArrayList();
            al.Add("India");
            al.Add("USA");
            al.Add("UK");
            //how do u access individual values
            Console.WriteLine(al[1]);
            // how to access all values
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            // to get total items
            Console.WriteLine("total items:"+al.Count);

            // how do u insert values
            al.Insert(1, "Canada");
            Console.WriteLine("----------------");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            al.Remove("India");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            al.RemoveAt(1);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }

        public void arraylistdemo2()
        {
            //what is capacity property
            ArrayList al = new ArrayList(10);
            al.Add("India");
            al.TrimToSize();
            //no of items arraylist can hold
            Console.WriteLine(al.Capacity);

        }
        public void arraylistdemo3()
        {
            // arraylist in realtime

            //how to store product details in arraylist
            ArrayList ar = new ArrayList();
            product p1 = new product();
            p1.pid = 101;
            p1.pname = "laptop";
            p1.price = 50000;
            ar.Add(p1);

            product p2 = new product();
            p2.pid = 102;
            p2.pname = "mobile";
            p2.price = 20000;
            ar.Add(p2);

            //shortcut to intialize object values
            product p3 = new product() { pid = 103, pname = "tablet", price = 30000 };
            ar.Add(p3);

            //method-3
            ar.Add(new product() { pid = 104, pname = "watch", price = 10000 });
            //view cart logic
            foreach (product p in ar)
            {
                Console.WriteLine("Product id:" + p.pid);
                Console.WriteLine("Product name:" + p.pname);
                Console.WriteLine("Product price:" + p.price);
            }




        }
        public void arralistdemo4()
        {
            //method-4
            //collection initializer
            ArrayList al = new ArrayList(10) {
            new product() { pid = 104, pname = "watch", price = 10000 },
            new product() { pid = 108, pname = "tablet", price = 30000 },
            new product() { pid = 10, pname = "pen", price = 100 }

            };
            mysortcls m= new mysortcls();

            al.Sort(m);  
            foreach (product p in al)
            {
                Console.WriteLine( p.pid +" : " +p.pname +" : " +p.price);
                
            }
        }

        public void arraylistdemo5()
        {
            // will see how sorting works
            ArrayList al = new ArrayList();
                al.Add(100);
                al.Add(200);
                al.Add(50);
            al.Sort();
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
        public void Hashtabledemo()
        {
            //use hashtable for larger data
            //for searching and sorting

            Hashtable ht = new Hashtable();
            ht.Add(101, "India");
            ht.Add(102, "USA");
            ht.Add(103, "UK");
            ht.Add(104, "Canada");
            SortedList sl = new SortedList(ht);
            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key +":"+ item.Value);

            }

        }
        public void stackdemo()
        {
            Stack s = new Stack();
            s.Push("http://google.com");
            s.Push("http://yahoo.com");
            s.Push("http://youtube.com");
            Console.WriteLine( s.Pop()); //removes the last element
            Console.WriteLine(s.Peek()); //prints the last element
            Console.WriteLine("-------------------");
            foreach (var item in  s)
            {
                Console.WriteLine(item);
            }
        
        }

        public void queuedemo()
        {
            Queue s = new Queue();
            s.Enqueue("Raj");
            s.Enqueue("Abhi");
            s.Enqueue("Siri");
            Console.WriteLine(s.Dequeue());
            Console.WriteLine("-------------------");

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
       
    }

    class mysortcls : IComparer
    {
        public int Compare(object x, object y)
        {
            product p1 = (product)x;
            product p2 = (product)y;
            return p1.pid.CompareTo(p2.pid);
        }
    }
}
