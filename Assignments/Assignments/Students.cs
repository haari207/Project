using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Students
    {
        public int studid { get; set; }
        public string studname { get; set; }
        public int Marks { get; set; }
        public void getdetails()
        {
            Console.WriteLine($"Student ID: {studid}");
            Console.WriteLine($"Student Name: {studname}");
            Console.WriteLine($"Marks: {Marks}");

         
                if (Marks > 60)
                {
                    Console.WriteLine($"First class: {studname}");
                }
                else if (Marks < 60 && Marks >= 50)
                {
                    Console.WriteLine($"Second class  {studname}");
                }
                else
                {
                    Console.WriteLine($"Fail :  {studname}");
                }

    }
    }

    }





