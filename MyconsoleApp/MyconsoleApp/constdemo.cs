using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class constdemo
    {
        // how to declare const
        //assign the values during declaration and the value cannot be changed
        //both the variable has to const if value is copied
        //cannot be called through object(only class)
        //const string data = "database path;file path";
        const string data = "name=jay age=21";
        public readonly string rs = "good afternoon";
        public  constdemo()
        {
            rs= "good morning";//value can be changed only via constructors

        }



        //keyword const
        //readonly
        // the value cannot be changed





    }
}
