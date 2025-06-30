using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class ipl
    {
        public string Teamname { get; set; }
        public  string captain { get; set; }
        public int budget { get; set; }

        public void details()
        {
            Console.WriteLine($"teamname: {Teamname}");
            Console.WriteLine($"captain: {captain}");
            Console.WriteLine($"budget: {budget}");
        }



    }
}
