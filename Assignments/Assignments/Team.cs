using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Team
    {
        public int Teamid { get; set; }

        public  Array Teamnames { get; set; }
        public void printteamdetails()
        {
            Console.WriteLine($"Team ID: {Teamid}");
            Console.WriteLine("Team Names:");
            foreach (var name in Teamnames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
