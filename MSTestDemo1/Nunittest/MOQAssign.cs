using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Resource;

namespace Nunittest
{


    public interface ICalculator
    {
        int Add(int a, int b);
    }
    public interface IParser
    {
        bool TryParse(string input, out int number);
    }
    public interface ILogger
    {
        void Log(string message);
    }
    public interface IConfig
    {
        string Environment { get; set; }
    }
    public interface INotifier
    {
        void Notify(string message);
    }
    public interface IDataReader
    {
        string ReadLine();
    }
    public interface IDiscountService
    {
        decimal ApplyDiscount(decimal amount);
    }
    public class MOQAssign : ICalculator,ICustomerRepository,IParser,ILogger,IConfig,INotifier,IDataReader,IDiscountService
    {

        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public string Name { get; internal set; }
        public string Environment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
        public bool TryParse(string input, out int number)
        {
            if(int.TryParse(input, out number))
            {
                return true;
            }
            number = 0;
            return false;
        }

        Customer ICustomerRepository.GetCustomerById(int id)
        {
            throw new NotImplementedException();
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
            Console.WriteLine("Reading a line from data source...");
            return "Sample line from data source";
        }

        public decimal ApplyDiscount(decimal amount)
        {
            return amount * 0.9m; 
        }
    }
    public class Customer
    {
        public string Name { get; internal set; }
    }
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
    }
   
    
}
