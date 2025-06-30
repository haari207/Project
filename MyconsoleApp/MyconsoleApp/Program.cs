using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Myclasslibrary;
using Mymathlib;
namespace MyconsoleApp
{
    internal class Program
    {

        //public static bool mylogic(int x)
        //{
        //    return x > 50;
        //}
        static void Main(string[] args)
        {
            //myrealdel d = (x) => { return x > 50; }; 
            //MymathCls.Add();
            //Console.WriteLine("hi students!!");
            #region //code 
            //MymathCls.greatest();
            //Day1Assignment.greatest3();
            //Day1Assignment.empdetails();
            //Day1Assignment.factorial();
            //Day1Assignment.sumof10nums();
            //Day1Assignment.swapnum();
            //Day1Assignment.copystr();
            //Day1Assignment.divnums();
            //Day1Assignment.printnames();
            //int m = 100;
            //Methodsdemo.valuetype(ref m);
            //Console.WriteLine(m);   
            //int p;
            //int q;
            //Methodsdemo.outputtype(10, 20, out p, out q);
            //Console.WriteLine("The sum is:" + p);
            //Console.WriteLine("The product is:" + q);
            //Methodsdemo.optionaltype(b:10,a:20);
            //Methodsdemo.paramstype( 1, 2, 3);
            //Methodsdemo.paramstype(1, 2);
            //Methodsdemo.paramstype();
            //Arraydemo.singledimension2();
            //Arraydemo.multidimension2();
            //Arraydemo.jaggedarray();
            //Arraydemo.boxingdemo();
            //Arraydemo.nullabledemo();

            //Arraydemo.unsafecode();
            //how to create object
            //login ob=new login();
            //ob.username = "mphasis";
            //ob.password = "India";
            //ob.validate();
            //employee ob1 = new employee();
            //Console.WriteLine("enter the age");
            //ob1.age = int.Parse(Console.ReadLine());
            //Console.WriteLine(ob1.age);
            //Console.WriteLine("enter the name");
            //ob1.empname = Console.ReadLine();
            ////Console.WriteLine(ob1.empname);
            //Console.WriteLine("enter the address");
            //ob1.address = Console.ReadLine();
            //Console.WriteLine(ob1.address);
            //ob1.id = 100;
            //Console.WriteLine(ob1.id);
            //object Initializer
            //ipl i = new ipl() { Teamname = "SRH", captain = "Abhishek", budget = 10000 };
            //i.Teamname = "SRH";
            //i.captain = "Abhishek";
            //i.budget = 1000000;
            //i.details();
            //childcls c=new childcls(10);//using child class obj we can call parent class method
            //childcls c1=new childcls(10); 
            //c.hi();
            //mycls m = new mycls();
            //m.helloworld();
            //mymathcls m1 = new mymathcls();
            //m1.add(10,20);
            //m1.sub(20, 10);
            //Staticdemo ob=new Staticdemo();
            //ob.add(10, 10);//int version is called
            //ob.add(10.0, 10.0);//double version is called
            //ob.add(10.0f, 10.0f);//float version is called
            //sqldb ob=new sqldb();
            //ob.connect();
            //ob.filter();
            //Console.WriteLine("========================="
            //sqldb ob;
            //ob = new oracledb();
            //ob.connect();
            //ob.filter();
            //Console.WriteLine("=========================");

            //ob = new mysql();
            //ob.connect();
            //ob.filter();   
            //Imath2 m = new Mymath();
            // m.Add(10, 20);
            //m.sub(20, 10);
            //m.divide(10, 20);
            //m.multiply(10, 20);
            //Console.WriteLine("age:" +staticdemo.age);
            //Console.WriteLine(staticdemo.x);
            //staticdemo.hi();

            //globalnamespace ob = new globalnamespace();
            //ob.display();
            //int k = 10;
            //Console.WriteLine(k.IsEven());
            //string a = "10";
            //Console.WriteLine(a.Tointeger());
            //c1 c1 = new c1();
            //int b = c1.add(10, 20);
            //Console.WriteLine(b);
            //p1 p = new p1();
            //p.add();
            //p.subtract();
            //p.multiply();
            //p.divide();

            // globalnamespace g=new globalnamespace();
            // g.display();

            //var t = g.getdata();
            // Console.WriteLine(t.Item1);
            // Console.WriteLine(t.Item2);

            //collection_demo c = new collection_demo();
            ////c.arraylistdemo();
            ////c.arraylistdemo2();
            //c.arraylistdemo3();
            //c.arralistdemo4();
            //c.arraylistdemo5();
            //c.Hashtabledemo();
            //c.stackdemo();
            //c.queuedemo();
            //employeelist e = new employeelist();
            //e.AddEmp("srinivas");
            //e.AddEmp("suresh");
            //Console.WriteLine(e[1]);
            ////e.displayall();

            //Linqdemo l= new Linqdemo();
            //l.demo1();
            //l.demo2();
            //l.demo6();

            //CODE TO CALL SHALLOW COPY
            //reference will be chnaged for both the object
            //Person p = new Person() { Name="hari",Age = 20, Address = new Address { City = "Hyderabad" } };
            //Person copy=p1.ShallowCopy();
            //Person p1=new Person(p);
            //p1.Name= "Abhi";
            //p1.Age = 22;
            //p1.Address.City = "Banglore";
            //p1.Display();
            //copy.Display();


            //CODE TO CALL DEEP COPY

            //Person copy = new Person(p);
            //p.Name = "jay";
            //p.Age = 23;
            //p.Address.City= "Banglore";//original value will not changed
            //p.Display();
            //copy.Display();
            //linkedlist l = new linkedlist();
            //l.display();
            //BinaryTree tree = new BinaryTree();
            //tree.Insert(50);
            //tree.Insert(30);
            //tree.Insert(70);
            //tree.Insert(20);
            //tree.Insert(40);
            //tree.Insert(60);
            //tree.Insert(80);

            //Console.WriteLine("Inorder Traversal:");
            //tree.InOrderTraversal(tree.Root);

            //Console.WriteLine("===============");
            //Console.WriteLine("preorder Traversal:");

            //tree.PreOrderTraversal(tree.Root);
            //Console.WriteLine("================");
            //Console.WriteLine("postorder Traversal:");

            //tree.PostOrderTraversal(tree.Root);


            //using (disposable d = new disposable())
            //{
            //    d.add();
            //    d.sub();
            //}


            //car basic=new Builderdemo().carname("Alto").price(100000).build();
            //basic .Displaycar();
            //Console.WriteLine("===============================");
            //car lux = new Builderdemo().carname("Ertiga").price(1200000).withAc(true).build();
            //lux.Displaycar();
            //Console.WriteLine("===============================");
            //car hightend = new Builderdemo().carname("Brezza").price(1500000).withAc(true).Rooftop(true).color("blue").build();
            //hightend.Displaycar();


            //pizza basic = new pizzademo().name("cheese").price(500).type(true).build();
            //basic.Displaypizza();
            //Console.WriteLine("==========================");
            //pizza high=new pizzademo().name("chicken").price(1000).type(false).size("large").build();
            //high.Displaypizza();
            //Console.Read();


            //IOstreamsdemo i = new IOstreamsdemo();
            //i.Readdata(new StreamReader("c:\\Mydir\\hello.txt"));
            //i.Readdata(new StringReader("this is a file"));
            //i.demo10();
            #endregion
            //Deldemo d=new Deldemo();
            //d.show(10);
            //Delrealtime ob =new Delrealtime();
            //int[] k = { 10, 20, 30, 40, 50, 60,70,80 };
            ////ob.FilterMethod(k,(x)=> x > 50);
            //ob.FilterMethod(k, (x) => x > 50 && x<80);
            //Multicastdemo m = new Multicastdemo();
            ////m.show();
            //m.callgen();

            //Builtindemo b=new Builtindemo();
            //b.display();
            
            clientcls e= new clientcls();
            e.execute();
            Console.Read();
        }

      
       
    }
}
