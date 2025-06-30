using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunittest
{
    internal class Fakedemo : Imath
    {
        public int Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler Myevent;

        //minimum code is return to pass the test
        public string Add(int x, int y)
        {
            return $"the sum is {x+y}"; 
        }
    }
}
