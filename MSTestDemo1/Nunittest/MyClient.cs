using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunittest
{
    public class MyClient
    {
        Imath math;
        public int Data { get { return math.Data; } set { math.Data = value; } }

        public MyClient(Imath m)
        {
            math = m;

        }
        public string AddClient(int x, int y)
        {
            string st= math.Add(x, y);
            return st;
        }

    }
}
