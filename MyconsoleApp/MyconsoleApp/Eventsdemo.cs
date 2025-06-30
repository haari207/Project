using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class Eventsdemo
    {
        //create events
        //create delegates
        //raise an event
        //it is like sendercode
        public delegate void senderdel(string msg);
        public event senderdel myevent;
        public void sendmessage()
        {
            myevent("Msg from server.....");

        }
            

    }
}
