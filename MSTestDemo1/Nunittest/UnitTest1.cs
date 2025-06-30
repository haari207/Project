using MyclassLib;
using NUnit.Framework;
namespace Nunittest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(10, 20, 30)] //provides test data  
        [TestCase(4, 6, 10)]
        public void Test1(int a, int b, int c)
        {
            MyClass ob = new MyClass();
            c = ob.Addnums(a, b);
            Assert.That(c, Is.EqualTo(30));
        }

        [Test, Ignore("no comments")]
        public void Test2()
        {
            MyClass ob = new MyClass();
            int c = ob.Multiply(6, 5);
            Assert.That(c, Is.EqualTo(30));
        }

        [Test]
        public void test3()
        {
            Assert.Throws<System.DivideByZeroException>(() =>
            {
                int denominator = 0;
                int c = 10 / denominator;
            });
        }

        [Test]
        [TestCase("madam", true)]
        [TestCase("hello", false)]
        [TestCase("", false)]
        public void test4(string input, bool expected)
        {
            StringUtils ob = new StringUtils();
            bool result = ob.IsPalindrome(input);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void test5()
        {
            BankAccount account = new BankAccount("John Doe", 1000);
            Assert.That(account.Balance, Is.EqualTo(1000));
            account.Deposit(500);
            Assert.That(account.Balance, Is.EqualTo(1500));
            account.Withdraw(200);
            Assert.That(account.Balance, Is.EqualTo(1300));
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(2000));
        }
        [Test]
        [TestCase("2023-10-07", true)]
        [TestCase("2023-10-09", false)]
        public void test6(string dateString, bool expected)
        {
            DateUtils ob = new DateUtils();
            DateTime date = DateTime.Parse(dateString);
            bool result = ob.IsWeekend(date);
            Assert.That(result, Is.EqualTo(expected));
        }


        [Test]
        [TestCase(4, true)]
        [TestCase(5, false)]
        [TestCase(0, true)]
        [TestCase(1, false)]
        public void test7(int number, bool expected)
        {
            MathUtils ob = new MathUtils();
            bool result = ob.IsEven(number);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        [TestCase(1, false)]
        [TestCase(0, false)]
       public void test8(int a,bool expected)
        {
            SessionManager s = new SessionManager();
            s.Start();
            Assert.That(s.IsActive, Is.True);
            s.End();
            Assert.That(s.IsActive, Is.False);

            Assert.That(s.IsActive, Is.EqualTo(expected), "Session should be active after start and inactive after end.");

        }
        [Test]
        [TestCase(20)]
        [TestCase(15)]
        public void test9(int age)
        {
            Validator v = new Validator();
            v.CheckAge(age);
        }
    }
}
