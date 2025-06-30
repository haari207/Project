using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunittest
{

    public class FakeClass : ICalculator, ICustomerRepository, IParser, ILogger, Iconfig,INotifier,IDataReader,IDiscountService
    {
        public string Environment { get; set; }

        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public decimal ApplyDiscount(decimal amount)
        {
            decimal d = amount;
            return d;
        }

        public Customer GetCustomerById(int id)
        {

            if (id == 1)
            {
                return new Customer()
                {
                    Name = "John"
                };
            }
            return new Customer();

        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return "This is a line from the data reader.";
        }

        public decimal RemoveDiscount(decimal amount)
        {
            decimal d = amount;
            return d;
        }

        public bool TryParse(string input, out int number)
        {
            if (int.TryParse(input, out number))
            {
                return true;
            }
            number = 0;
            return false;
        }
    }

    public interface Iconfig
    {
        string Environment { get; set; }
    }

}
