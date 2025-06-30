using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class clientcls
    {

        //code to receive the msg
        Eventsdemo ob=new Eventsdemo();
        public clientcls() {
            ob.myevent += Ob_myevent;
        
        }

        private void Ob_myevent(string msg)
        {
            //receive the msg from the server
            Console.WriteLine(msg);

        }
        public void execute()
        {
            ob.sendmessage();                                                 
        }
    }
}
