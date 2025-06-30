using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFpatterns
{
    interface Mydb
    {
        string[] showdata();
    }
    internal class Sqldata:Mydb
    {
        public string[] showdata()
        {
            string[] data = { "India", "UK", "USA" };
            return data;
        }

    }
    internal class Oracledata : Mydb
    {
        public string[] showdata()
        {
            string[] data = { "CSK", "SRH", "RCB" };
            return data;
        }

    }

    internal class Mysqldata : Mydb
    {
        public string[] showdata()
        {
            string[] data = { "Prabhas", "NTR", "Ram" };
            return data;
        }

    }

    class Factory
    {
        
        // this class will return the instance based upon the input
        public Mydb getinstance(int i)
        {
            if (i == 1)
            {
                return new Sqldata();
            }
            else if(i == 2) 
            {
                return new Oracledata();
            }
            else
            {
                return new Mysqldata();
            }
           
        }



    }




}
