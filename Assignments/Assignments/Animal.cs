using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Animal
    {
        public virtual void makesound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
    class dog : Animal
    {
        public override void makesound()
        {
            Console.WriteLine("Dog barks it is from dog class");
        }
    }
    class cat : Animal
    {
        public override void makesound()
        {
            Console.WriteLine("Cat meows it is from cat class");
        }
    }
}
