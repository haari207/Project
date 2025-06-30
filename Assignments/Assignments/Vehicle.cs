using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Vehicle
    {
        public virtual void drive()
        {
            Console.WriteLine("Vehicle is driving");
        }
    }
    class Car : Vehicle
    {
        public override void drive()
        {
            Console.WriteLine("Car is driving");
        }
    }
    class Bike : Vehicle
    {
        public override void drive()
        {
            Console.WriteLine("Bike is driving");
        }
    }
}
