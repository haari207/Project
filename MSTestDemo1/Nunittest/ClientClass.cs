using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunittest
{
    public class ClientClass
    {
        ICalculator calculate;
        IParser p;
        IConfig config;
        INotifier notifier;
        IDataReader reader;
        IDiscountService ds;
        public string Environment { get { return config.Environment; }  set { config.Environment = value; }}

        public ClientClass(ICalculator c)
        {
            calculate = c;
        }
        public int AddClient(int a, int b)
        {
            int c = calculate.Add(a, b);
            return c;

        }
        public ClientClass(IParser parser)
        {
            p = parser;
        }
        public bool ParseInput(string input, out int number)
        {
            return p.TryParse(input, out number);
        }
        public ClientClass(IConfig c)
        {
            config = c;
        }

        // In ClientClass
        public void SetEnvironment(string env)
        {
            config.Environment = env;
        }
        public ClientClass(INotifier notifier)
        {
            this.notifier = notifier;
        }
        public void Notify(string message)
        {
            notifier.Notify(message);
        }
        public ClientClass(IDataReader reader)
        {
            this.reader = reader;
        }
        public string ReadData()
        {
            return reader.ReadLine();
        }

        public ClientClass(IDiscountService ds)
        {
            this.ds = ds;
        }
        public decimal ApplyDiscount(decimal amount)
        {
            return ds.ApplyDiscount(amount);
        }

    }
    public class CustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public string GetCustomerName(int id)
        {
            var customer = _repo.GetCustomerById(id);
            return customer?.Name ?? "Unknown";
        }
    }
    public class Processor
    {
        private readonly ILogger _logger;
        public Processor(ILogger logger)
        {
            _logger = logger;
        }

        public void Process()
        {
            _logger.Log("Start");
            _logger.Log("Processing");
            _logger.Log("End");
        }
    }
}