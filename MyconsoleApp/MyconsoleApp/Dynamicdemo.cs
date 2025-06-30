using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal abstract  class sqldb
    {

        public string[] names;

        public abstract void connect(); //abstract method the logic will be called in subclass
        //public virtual void connect()
        //{
        //    //logic to read from sql
        //    names = new string[] { "Srilanka", "India", "Canada", "USA", "UK", "Swiz" };
        //}
        public void filter()
        {
            foreach (string name in names)
            {
                if (name.StartsWith("S"))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
    class oracledb : sqldb
    {
        public override void connect()
        {

            names = new string[] { "Sweden", "Sydney", "India", "Canada", "UK" };
        }

    }
    class mysql : sqldb
    {
        public override void connect()
        {
            names = new string[] { "Syria", "India", "UK", "SouthAfrica" };


        }
    }
}
