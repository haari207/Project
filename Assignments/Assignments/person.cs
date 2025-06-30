using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class personcls
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    class employee : personcls
    {
        public int salary { get; set; }
    }
    class manager : employee
    {
        public int bonus { get; set; }
    }
}