using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GOFpatterns.Observer;
using static GOFpatterns.Prototype;

namespace GOFpatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var ob=Singletonpattern.getinstance;
            //ob.method();

            //how to access factory pattern
            //Factory f = new Factory();
            //var ob = f.getinstance(3);
            //var data = ob.showdata();
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}
            //Circle ob=new Circle();
            //ob.Radius = 10;
            //ob.Color = "Red";
            //ob.Draw();
            //Circle ob1=new Circle();
            //ob1 = (Circle)ob.Clone();
            //ob1.Color= "Blue";
            //ob.Draw();
            //ob1.Draw();

            //how to access older pattern  and new printer using adapter pattern
            //IPrinter ob = new ModernPrinter();
            //ob.Print("Hello, World!");
            //// Using the adapter
            //LegacyPrinter ob1 = new LegacyPrinter();
            //IPrinter p = new LegacyPrinterAdapter(ob1);
            //p.Print("Hello, World! (via adapter)");


            //first time
            //login l = new login();
            //l.checkuser();

            //product p = new product();
            //p.addproduct();

            //makepayment m = new makepayment();
            //m.processpayment();

            //sendmail s = new sendmail();
            //s.mailtouser();
            //faced f = new faced();
            //f.buyproduct();
            //Template t=new online();
            //t.processdata();
            //Console.WriteLine("-------------------------------------------------");
            //Template t2 = new physicaldelivery();
            //t2.processdata();

            NotificationService notificationService = new NotificationService();

            User user1 = new User("Alice");
            User user2 = new User("Bob");

            notificationService.Subscribe(user1);
            notificationService.Subscribe(user2);

            notificationService.NotifyObservers("New update available!");
            Console.WriteLine("=====================");
            notificationService.Unsubscribe(user1);
            Console.WriteLine("Have a great day!!");

            Console.Read();
        }
    }
}
