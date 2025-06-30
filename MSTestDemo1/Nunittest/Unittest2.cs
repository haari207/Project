using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace Nunittest
{
    [TestFixture]
    public class Unittest2
    {
        [Test]
        public void Demo1()
        {
            //Myservice real = new Myservice();
            //Stubdemo fake = new Stubdemo();
            Fakedemo f = new Fakedemo();
            MyClient client = new MyClient(f);
            string result = client.AddClient(10, 20);
            Assert.That(result, Is.EqualTo("the sum is 30"));


        }

        [Test]
        public void demo2()
        {

            var fakemoq = new Mock<Imath>();
            fakemoq.Setup(c => c.Add(10, 20)).Returns("the sum is 30");
            //Fakedemo f = new Fakedemo();
            MyClient client = new MyClient(fakemoq.Object);
            string result = client.AddClient(10, 20);
            Assert.That(result, Is.EqualTo("the sum is 30"));

        }

        [Test]
        public void demo3()
        {

            var fakemoq = new Mock<Imath>();
            fakemoq.Setup(c => c.Add(10, 20)).Returns("the sum is 30");
            MyClient client = new MyClient(fakemoq.Object);
            string result = client.AddClient(10, 20);
            Assert.That(result, Is.EqualTo("the sum is 30"));
            fakemoq.Verify(c => c.Add(10, 20), Times.Once); // Verify that Add was called once with the specified parameters           

        }

        [Test]
        public void demo4()
        {
            var fakemoq = new Mock<Imath>();
            fakemoq.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns("the sum is 30");
            MyClient client = new MyClient(fakemoq.Object);
            string result = client.AddClient(10, 20);
            Assert.That(result, Is.EqualTo("the sum is 30"));
            fakemoq.Verify(c => c.Add(10, 20), Times.Once);

        }
        [Test]
        public void demo5()
        {
            var fakemoq = new Mock<Imath>();
            fakemoq.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => $"the sum is {a + b}");
            MyClient client = new MyClient(fakemoq.Object);
            string result = client.AddClient(10, 20);
            Assert.That(result, Is.EqualTo("the sum is 30"));
            fakemoq.Verify(c => c.Add(10, 20), Times.Once);

        }

        [Test]
        public void demo6()
        {
            var fakemoq = new Mock<Imath>();
            fakemoq.Setup(c => c.Add(It.Is<int>(i => i > 5), It.IsAny<int>())).Returns("the sum is 30");
            MyClient client = new MyClient(fakemoq.Object);
            string result = client.AddClient(10, 20);
            Assert.That(result, Is.EqualTo("the sum is 30"));
            fakemoq.Verify(c => c.Add(10, 20), Times.Once);

        }
        [Test]
        public void demo7()
        {
            var fakemoq = new Mock<Imath>();
            fakemoq.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Callback<int, int>((a, b) => Console.WriteLine($"Method executed successfully {a} {b}"))
                               .Returns("the sum is 30");
            MyClient client = new MyClient(fakemoq.Object);
            string result = client.AddClient(10, 20);
            Assert.That(result, Is.EqualTo("the sum is 30"));
            fakemoq.Verify(c => c.Add(10, 20), Times.Once);

        }
        [Test]
        public void demo8()
        {
            var fakemoq = new Mock<Imath>();
            fakemoq.Setup(x => x.Add(-1, -1)).Throws<ArgumentException>();
            MyClient client = new MyClient(fakemoq.Object);

            Assert.Throws<ArgumentException>(() => client.AddClient(-1, -1));

        }

        [Test]
        public void demo9()
        {
            //how to test properties
            var fakemoq = new Mock<Imath>();
            fakemoq.SetupProperty(x => x.Data, 10);       //calls set block
            fakemoq.SetupGet(x => x.Data).Returns(10);  //calls get block which will read data and return a value
            MyClient client = new MyClient(fakemoq.Object);
            Assert.That(client.Data, Is.EqualTo(10));
        }
        [Test]
        public void demo10()
        {
            //will cretae a mock to test whether event i called or not

            //how to test events
            var fakemoq = new Mock<Imath>();
            bool wascalled = false;
            fakemoq.Object.Myevent += (s, e) => wascalled = true; //subscribing to the event
            fakemoq.Raise(c => c.Myevent += null, EventArgs.Empty); //raising the event
            Assert.That(wascalled, Is.True); //checking whether the event was called or not
        }

        [Test]
        public void m1()
        {
            var fakemoq = new Mock<ICalculator>();
            fakemoq.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a + b);
            ClientClass c = new ClientClass(fakemoq.Object);
            int result = c.AddClient(2, 3);
            Assert.That(result, Is.EqualTo(5));
            fakemoq.Verify(c => c.Add(2, 3), Times.Once);
        }

        [Test]
        public void m2()
        {
            var fakemoq = new Mock<ICustomerRepository>();
            fakemoq.Setup(c => c.GetCustomerById(It.IsAny<int>())).Returns((int id) => new Customer { Name = id == 1 ? "John" : "Unknown" });
            CustomerService service = new CustomerService(fakemoq.Object);
            string customerName = service.GetCustomerName(1);
            Assert.That(customerName, Is.EqualTo("John"));
        }

        [Test]
        public void m3()
        {
            var fakemoq = new Mock<ICustomerRepository>();
            fakemoq.Setup(c => c.GetCustomerById(-1)).Throws<ArgumentException>();
            CustomerService service = new CustomerService(fakemoq.Object);
            Assert.Throws<ArgumentException>(() => service.GetCustomerName(-1));
        }

        [Test]
        public void m4()
        {
            var fakemoq = new Mock<IParser>(MockBehavior.Strict);
            fakemoq.Setup(c => c.TryParse(It.IsAny<string>(), out It.Ref<int>.IsAny)).Returns((string input, out int number) =>
            {
                if (int.TryParse(input, out number))
                {
                    return true;
                }
                number = 0;
                return false;
            });
            ClientClass client = new ClientClass(fakemoq.Object);
            Assert.That(client.ParseInput("123", out int number), Is.True);
            fakemoq.Verify(c => c.TryParse("123", out number), Times.Once);
        }
        [Test]
        public void m5()
        {
            var fakemoq = new Mock<ILogger>();
            fakemoq.Setup(c => c.Log(It.IsAny<string>())).Callback<string>(message => Console.WriteLine($"Logged: {message}"));
            Processor p = new Processor(fakemoq.Object);
            p.Process();
            fakemoq.Verify(c => c.Log(It.IsAny<string>()), Times.Exactly(3));


        }
        [Test]
        public void m6()
        {
            var fakemoq = new Mock<IConfig>();
            fakemoq.SetupProperty(c => c.Environment, "Development");
            ClientClass client = new ClientClass(fakemoq.Object);
            client.SetEnvironment("Production");
            Assert.That(client.Environment, Is.EqualTo("Production"));
            fakemoq.VerifySet(c => c.Environment = "Production", Times.Once);
        }

        [Test]
        public void m7()
        {
            var fakemoq = new Mock<INotifier>();
            fakemoq.Setup(c => c.Notify(It.IsAny<string>())).Callback<string>(message => Console.WriteLine($"Notification sent: {message}"));
            ClientClass client = new ClientClass(fakemoq.Object);
            client.Notify("Test message");
            fakemoq.Verify(c => c.Notify("Test message"), Times.Once);
        }
        [Test]
        public void m8()
        {
            var fakemoq = new Mock<IDataReader>();
            fakemoq.Setup(c => c.ReadLine()).Returns("This is a line from the data reader.");
            ClientClass client = new ClientClass(fakemoq.Object);
            string data = client.ReadData();
            Assert.That(data, Is.EqualTo("This is a line from the data reader."));
            fakemoq.Verify(c => c.ReadLine(), Times.Once);
        }

        [Test]
        public void m9()
        {
            var fakemoq = new Mock<IDiscountService>();
            fakemoq.Setup(c => c.ApplyDiscount(It.IsAny<decimal>())).Returns((decimal amount) => amount * 0.9m);
            ClientClass client = new ClientClass(fakemoq.Object);
            decimal discountedAmount = client.ApplyDiscount(100);
            Assert.That(discountedAmount, Is.EqualTo(90));
            fakemoq.Verify(c => c.ApplyDiscount(100), Times.Once);
        }
 

    }
}

