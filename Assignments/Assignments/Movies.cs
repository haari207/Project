using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Movies
    {
        public int movieId { get; set; }
        public string Moviename { get; set; }
        public string Actor { get; set; }
        public string Actress { get; set; }

        public void showdetails()
        {
            Console.WriteLine($"Movie ID: {movieId}");
            Console.WriteLine($"Movie Name: {Moviename}");
            Console.WriteLine($"Actor: {Actor}");
            Console.WriteLine($"Actress: {Actress}");
        }


    }
}
