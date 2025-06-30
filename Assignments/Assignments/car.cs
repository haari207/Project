using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class car
    {
        public  string carname { get; set; }
        public string carcolor { get; set; }
        public string carmodel { get; set; }
        public string carbrand { get; set; }
        public int carprice { get; set; }
        public void displaycardetails()
        {
            Console.WriteLine($"Car Name: {carname}");
            Console.WriteLine($"Car Color: {carcolor}");

            Console.WriteLine($"Car Model: {carmodel}");
            Console.WriteLine($"Car Brand: {carbrand}");
            Console.WriteLine($"Car Price: {carprice}");
        }
    }
}
