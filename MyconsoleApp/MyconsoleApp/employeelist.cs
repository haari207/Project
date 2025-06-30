using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class employeelist
    {
        ArrayList ar = new ArrayList();
        public void AddEmp(string name)
        {
            ar.Add(name);
        }
        public object this[int index]
        {
            get
            {
                return ar[index].ToString();
            }
           
        }
        public void displayall()
        {
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
        }




    }
}
