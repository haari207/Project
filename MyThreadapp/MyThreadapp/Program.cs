using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyThreadapp
{
    internal class Program
    {
        static Semaphore s = new Semaphore(3, 3);
        //static AutoResetEvent handle = new AutoResetEvent(false);
        static EventWaitHandle handle = new ManualResetEvent(false);


        static void Main(string[] args)
        {
            #region
            //Mutex m = new Mutex(true, "hi");
            //if (!m.WaitOne(2000))
            //{

            //    Console.WriteLine("Another Instance is already running");
            //}
            //else
            //{
            //    try
            //    {
            //        run();
            //    }
            //    finally
            //    {
            //        m.ReleaseMutex();
            //    }
            //}



            //sequntial
            //Threadcls t=new Threadcls();
            //t.m1();
            //t.m2();
            //parallel
            //Threadcls t = new Threadcls();
            //ThreadPool.QueueUserWorkItem(t.method1, "first pool called");
            //ThreadPool.QueueUserWorkItem(t.method2, "second pool called");

            //Thread tt = new Thread(execute);
            //tt.IsBackground =true;
            //tt.Start();

            //for (int i = 0; i < 20; i++)
            //{
            //    new Thread(Program.DoSomething).Start(i);

            //}

            #endregion
            //new Thread(SayHello).Start("hello-1");
            //new Thread(SayHello).Start("hello-2");
            //new Thread(SayHello).Start("hello-3");
            //Thread.Sleep(2000);
            //handle.Set();//execute 1 method at a time
            //Thread.Sleep(2000);
            //handle.Set();
            //Thread.Sleep(2000);
            //handle.Set();


            //handle.Set();
            //new Thread(SayHello).Start("hello-1");
            //new Thread(SayHello).Start("hello-2");
            //new Thread(SayHello).Start("hello-3");
            //new Thread(SayHello).Start("hello-1");
            //new Thread(SayHello).Start("hello-2");
            //new Thread(SayHello).Start("hello-3");
            //Thread.Sleep(2000);
            //handle.Reset();
            //new Thread(SayHello).Start("hello-4");
            //Thread.Sleep(4000);
            //handle.Set();



            //Serializtiondemo demo = new Serializtiondemo();
            //demo.serialization();
            //demo.deserialization();
            //demo.binarydeserialize();



            //Customrs customrs = new Customrs();
            //customrs.serializedata();
            //customrs.deserializedata();

            //customrs.deserializedemo();



            //Originator originator = new Originator();
            //Caretaker caretaker = new Caretaker();

            //originator.State = "Initial State";
            //Console.WriteLine("State set to: " + originator.State);

            //Memento savedState = originator.SaveState();
            //caretaker.SaveToXml(savedState, "memento.xml");

            //originator.State = "Modified State";
            //Console.WriteLine("State changed to: " + originator.State);

            //// Restore from XML
            //Memento restoredState = caretaker.LoadFromXml("memento.xml");
            //originator.RestoreState(restoredState);
            //Console.WriteLine("State restored to: " + originator.State);



            Reflction_demo r= new Reflction_demo();
            r.demo4();
            Console.Read();

            //Console.WriteLine("Main function app exited");

            //Console.Read();

            //Thread t1 = new Thread(t.m3); // runs m1 seperate method
            //Thread t2 = new Thread(t.m2); //runs m2 seperate method
            //Thread t1=new Thread(t.filehandling);
            //t1.Name = "first";
            //Thread t2 = new Thread(t.filehandling);
            //t2.Name = "second";
            //t1.Start();
            //t2.Start();
            //t1.Join();//other thread has to wait until t1 is completed.
            //t2.Start();

        }
        //public static void run()
        //{
        //    //show this msg for the firsttime
        //    Console.WriteLine("Application is currently running");
        //    Console.ReadLine();
        //}
        //public  static void execute()
        //{
        //    Console.WriteLine("Method-1 Entered");
        //    Console.ReadLine();
        //    Console.WriteLine("Method-1 Exited");
        //}
        //public static void DoSomething(object id)
        //{
        //    Console.WriteLine(id + "wants to access the semaphore");
        //    s.WaitOne();
        //    Console.WriteLine(id + "has succeed to access the semaphore");
        //    Thread.Sleep(3000);
        //    Console.WriteLine(id + "is above to leave semaphore");
        //    s.Release();

        //}
        //public static void SayHello(object data)
        //{
        //    Console.WriteLine("inside say hello  " + data);
        //    handle.WaitOne(); //wait until event is called
        //    Console.WriteLine(data);
        //}
        public static void SayHello(object data)
        {
            Console.WriteLine("inside say hello  " + data);
            handle.WaitOne();
            Console.WriteLine(data);
        }
    }
}



