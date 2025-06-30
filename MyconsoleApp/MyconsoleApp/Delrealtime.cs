using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    public delegate bool myrealdel(int x);

    internal class Delrealtime
    {
        public void FilterMethod(int[] data,myrealdel d)
        {
            foreach (int i in data)
            {
               // if (i > 30)
               if(d.Invoke(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

       


    }
}
