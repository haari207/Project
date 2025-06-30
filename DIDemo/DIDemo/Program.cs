using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Unity;
namespace DIDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //ServiceCollection s = new ServiceCollection();
            var services=new ServiceCollection();
            //services.AddSingleton<Imath, Service>(); // Singleton means the instance is created once and reused
            //services.AddScoped<Imath, Service>();      // Scoped means the instance is created once per request
            services.AddKeyedScoped<Imath,Bestservice>("hi");
            //services.AddTransient<Imath, Service>(); // Transient means a new instance is created every time it is requested
            // s.AddScoped<Imath, Service>();
            //s.AddTransient<Imath, Service>(); //transient means every time a new instance is created
            var sp =services.BuildServiceProvider();
            using (var scope1 = sp.CreateScope())
            {
                //var service1 = scope1.ServiceProvider.GetRequiredService<Imath>();
                var service1 = scope1.ServiceProvider.GetRequiredKeyedService<Imath>("hi");
                service1.Add(10, 20);
                var service2 = scope1.ServiceProvider.GetRequiredService<Imath>();
                service2.Add(10, 10);
            }
            using (var scope2 = sp.CreateScope())
            {
                var service3 = scope2.ServiceProvider.GetRequiredService<Imath>();
                service3.Add(20, 30);
            }


                //}
                //    var sc=s.BuildServiceProvider(); //generates instance
                //var sc1 = s.BuildServiceProvider();
                //var ob=sc.GetService<Imath>();
                //var ob1 = sc.GetService<Imath>();
                //ob.Add(10, 20);
                //ob.Add(10, 10);
                //ob1.Add(10, 20);
                //ob1.Add(10, 10);

                //object creation instance management all happens here
                // u need to use packages in main function
                // where ever object is created

                //UnityContainer c = new UnityContainer();//this class is used to manage instance
                //// c.RegisterSingleton<Imath, Service>(); // this is called interface based injection
                // //how do u call add method
                ////c.RegisterInstance<Imath>(new Service()); 
                // c.RegisterFactory<Imath>(f => new Service()); 
                // var obj=c.Resolve<Imath>();
                // var obj1=c.Resolve<Imath>(); //to access the instance use resolve method
                // //var obj2=c.Resolve<Imath>(); //to access the instance use resolve method
                // obj.Add(10, 20);
                // obj.Add(10, 20);

                // obj1.Add(10, 10);
                // obj1.Add(10, 10);

                //Service s=new Service();
                //Bestservice b=new Bestservice();
                //User ob = new User();
                ////ob.Myserviceinstance = s; // this is called property injection
                //ob.show(b);


                //DEPENDENCY INJECTION USING KEY
                //UnityContainer u =new UnityContainer();
                //u.RegisterSingleton<Imath, Service>("hi");
                //u.RegisterSingleton<Imath, Bestservice>("hello");

                //var ob=u.Resolve<Imath>("hello");
                //ob.Add(10, 20);

            
        }
    }
}
