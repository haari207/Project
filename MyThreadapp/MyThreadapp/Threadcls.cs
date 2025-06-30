using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyThreadapp
{
    internal class Threadcls
    {
        public void method1(object ob)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("method1 called" + i + ':' + ob);
                Thread.Sleep(1000);
            }

        }

        public void method2(object ob)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("method2 called" + i + ':' + ob);
                Thread.Sleep(1000);
            }

        }



        public void m1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("M1 Called :" + i);
                Thread.Sleep(1000); // 1sec
            }
        }

        public void m2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("M2 Called :" + i);
                Thread.Sleep(1000); // 1sec
            }
        }

        public void m3()
        {
            Thread t = new Thread(m4);

            for (int i = 0; i <= 30; i++)
            {
                Console.WriteLine("m3 called" + i);
                Thread.Sleep(1000);
                if (i == 5)
                {

                    Console.WriteLine("M4 started:");
                    t.Start();
                }
                else if (i == 10)
                {

                    Console.WriteLine("m4 paused");
                    t.Suspend();
                }
                else if (i == 15)
                {

                    Console.WriteLine("m4 Resume");
                    t.Resume();
                }
                else if (i == 20)
                {
                    Console.WriteLine("m4 killed");
                    t.Abort();
                }
                else if (i == 25)
                {
                    Console.WriteLine("m3 aborted");
                    Thread.CurrentThread.Abort();
                }
            }
        }

        public void m4()
        {
            while (true)
            {
                Console.WriteLine("m4 called");
                Thread.Sleep(1000);
            }
        }

        public void filehandling()
        {

            //Monitor.Enter(this); //lock applied 
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name);
                    Thread.Sleep(1000);
                }
                //Monitor.Exit(this); //lock is released                                                                                                          
            }

        }
       




    }
}
