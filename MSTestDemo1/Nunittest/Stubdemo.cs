using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunittest
{
    internal class Stubdemo:Imath
    {
        public int Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler Myevent;

        public string Add(int x, int y)
        {
            return "the sum is 10";
        }




    }
}
