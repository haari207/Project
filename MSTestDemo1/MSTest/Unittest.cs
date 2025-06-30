using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyclassLib;

namespace MSTest
{

    [TestClass]
    public class Unittest
    {
        [ClassInitialize]
        //it should always be public,void no reutn type
        public static void M1(TestContext t)
        {
            Console.WriteLine("classinitialize called");
        }
        [ClassCleanup]
        public  static void M2()
        {
            Console.WriteLine("class cleanup called");
        }
        [TestInitialize]
        public void t1()
        {
            Console.WriteLine("test initialize called");
        }
        [TestCleanup]
        public void t2()
        {
            Console.WriteLine("test cleanup called");
        }

        [TestMethod]
        public void method1()
        {
            Console.WriteLine("method1 called");
        }
        [TestMethod]
        public void method2()
        {
            Console.WriteLine("method2 called");
        }

        [TestMethod]
        [DataRow(10, 20, 30)]
        public void Method3(int a, int b, int c)
        {
            MyClass ob = new MyClass();
            int result = ob.Addnums(a, b);
            Assert.AreEqual(c, result);
            //debugging 
            //step into:tracing line by line (f11)
            //step over:skip the function (f10)
            //stepout:run all remaining code (shift+f11)
        }
    }

}
