using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var services= new ServiceCollection();
            services.AddKeyedScoped<Icustomer, CustomerService>("hello");
            services.AddKeyedScoped<Icustomer, Inmemoryservice>("hi");
            var sp = services.BuildServiceProvider();
            using (var scope1 = sp.CreateScope())
            {
                //var service1 = scope1.ServiceProvider.GetRequiredKeyedService<Icustomer>("hi");
                var service2 = scope1.ServiceProvider.GetRequiredKeyedService<Icustomer>("hello");

                service2.Addcustomer(new Customer
                {
                    cid = 600,
                    cname = "Akshaya",
                    DOB = DateTime.Now,
                    caddress = "UK",
                    cphone = "1234567890",
                    pan = "ABCDE1234F"
                });
                service2.Displaycustomer(new List<Customer>());
                


            }
            





        }
    }
}
