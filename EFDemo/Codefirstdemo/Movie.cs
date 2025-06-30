using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirstdemo
{
   public  class Movie
    {
        [Key] //specifying primary key
        public int Movieid { get; set; }
        public string Moviename { get; set; }
        public string Actor { get; set; }
        public string Actress { get; set; }
        public int YOR { get; set; }


    }
}
