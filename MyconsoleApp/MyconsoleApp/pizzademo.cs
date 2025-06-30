using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{


    class pizza
    {
        public int price { get; set; }
        public bool type { get; set; }

        public string name { get; set; }

        public string size { get; set; }

        public void Displaypizza()
        {
            Console.WriteLine($"PizzaName:{name}");
            Console.WriteLine($"PizzaType:{(type ? "veg":"nonveg")}");
            Console.WriteLine($"PizzaSize:{size}");
            Console.WriteLine($"PizzaPrice:{price}");
        }

    }
    internal class pizzademo
    {
        pizza p=new pizza();

        public pizzademo price(int price)
        {
            p.price = price;
            return this;
        }
        public pizzademo type(bool type)
        {
            p.type = type;
            return this;
        }
        public pizzademo name(string name)
        {
            p.name = name;
            return this;
        }
        public pizzademo size(string size)
        {
            p.size = size;
            return this;
        }
        public pizza build()
        {
            return p;
        }

    }
}
