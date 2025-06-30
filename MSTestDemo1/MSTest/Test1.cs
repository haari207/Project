using MyclassLib;
namespace MSTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange-Act-Assert
            int a = 5;
            int b = 6;
            int c = a + b;
            Assert.AreEqual(11, c);


        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange-Act-Assert
            MyClass myClass = new MyClass();//arrange
            int c = myClass.Addnums(5, 10);//act
            Assert.AreEqual(15, c);//assert
        }

        [TestMethod]
        public void Greatest_twonums_returnsGreatest()
        {
            //test greatest of two numbers
            MyClass myClass = new MyClass(); // Arrange
            int result = myClass.Greatest(10, 20); // Act
            Assert.AreEqual(20, result); // Assert
        }

        [TestMethod]
        public void multiplication_twomums_returnsresult()
        {
            MyClass myClass = new MyClass();
            int result = myClass.Multiply(5, 10); // Act
            Assert.AreEqual(50, result); // Assert
        }                                                       
        [TestMethod]
        public void returns_sumofarrays()
        {
            MyClass ob= new MyClass();
            int[]C = ob.sumofarrays(); // Act
            Assert.AreEqual(5, C.Sum());
        }

        [TestMethod]
        [DataRow(10,20,30)]
        public void TestMethod3(int a, int b,int c)
        {
            MyClass ob= new MyClass();
            int result = ob.Addnums(a, b);
            Assert.AreEqual(c, result);
        }

        [TestMethod]
        [DataRow("1,2,3", "4,5,6", 21)]
        public void returns_arrays(string a, string b, int c)
        {
            int[] d = a.Split(',').Select(int.Parse).ToArray();
            int[] e = b.Split(',').Select(int.Parse).ToArray();
            MyClass ob = new MyClass();
            int sum = ob.sumofarrays(d, e);
            Assert.AreEqual(c, sum);
        }

    }
}
