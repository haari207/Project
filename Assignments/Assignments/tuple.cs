using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class tuple
    {
        public Tuple<string, string> splitfullname(string fullname)
        {
            
            string[] names = fullname.Split(' ');
            string firstName = names[0].Trim();
            string lastName = names[1].Trim();
            Tuple<string, string> Tuple = new Tuple<string, string>(firstName, lastName);
            return Tuple;
        }
    }
}
