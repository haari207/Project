using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    interface Iperson
    {
        void Getdetails();
    }
    internal partial class Employee
    {
        public int salary { get; set; }
        public string Empname { get; set; }
        public string dept { get; set; }

    }
    
}
