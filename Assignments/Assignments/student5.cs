using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal  class student5
    {
        public int studentid { get; set; }
        public string studentname { get; set; }
        public int[] marks { get; set; } = new int[4];

        public int totalmarks { get; set; }
        public int avg { get; set; }
        public void getdetails()
        {
            Console.WriteLine($"Student ID: {studentid}");
            Console.WriteLine($"Student Name: {studentname}");
            Console.WriteLine("Marks:");

            foreach (var mark in marks)
            {
                Console.WriteLine(mark);
                totalmarks += mark;
            }
            avg = totalmarks / marks.Length;
            Console.WriteLine($"Average Marks: {avg}");
            if (avg > 60)
            {
                Console.WriteLine($"First class: {studentname}");
            }
            else if (avg < 60 && avg >= 50)
            {
                Console.WriteLine($"Second class: {studentname}");
            }
            else
            {
                Console.WriteLine($"Fail: {studentname}");
            }
        }
        public static void getbyid(student5[] students,int id)
        {
          foreach (var student in students)
            {
                if (student.studentid == id)
                {
                    student.getdetails();
                    return;
                }
            }

        }
        public  void getfirstclassdata(  )
        {
            foreach (var mark in marks)
            {
                avg = totalmarks / marks.Length;
                avg = +mark;
                if (avg> 60)
                {
                    Console.WriteLine($"First class: {studentname}");
                }
                
            }
        }
          
        public  void GetByChar(student5[] students)
        {
            Console.WriteLine("List of students whose names start with 'S':");
            foreach (var student in students)
            {
                if (!string.IsNullOrEmpty(student.studentname) && student.studentname.StartsWith("S", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(student.studentname);
                }
            }
        }
    }
}
