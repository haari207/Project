using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    class car
    {
        public string carname { get; set; }
        public bool Rooftop { get; set; }
        public string color { get; set; }
        public bool withAC { get; set; }
        public int price { get; set; }

        public void Displaycar()
        {
            Console.WriteLine($"carName:{carname}");
            Console.WriteLine($"carRooftop:{(Rooftop ? "withRoof" : "withoutRoof")}");
            Console.WriteLine($"carcolor:{color}");
            Console.WriteLine($"carwithAC:{(withAC ? "withAC" : "withoutAC")} ");
            Console.WriteLine($"carprice:{price}");


        }

    }
    internal class Builderdemo
    {
        car c = new car();
        public Builderdemo carname(string carname)
        {
            c.carname = carname;
            return this;

        }
        public Builderdemo withAc(bool withAC)
        {
            c.withAC = withAC;
            return this;
        }
        public Builderdemo color(string color)
        {
            c.color = color;
            return this;
        }
        public Builderdemo Rooftop(bool Rooftop)
        {
            c.Rooftop = Rooftop;
            return this;
        }
        public Builderdemo price(int price)
        {
            c.price = price;
            return this;
        }
        public car build()
        {
            return c;
        }
    }
}

