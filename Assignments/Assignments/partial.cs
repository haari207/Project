using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal partial class Employee:Iperson
    {
        public void Getdetails()
        {
            Console.WriteLine("Employee Name: " + Empname);
            Console.WriteLine("Employee Salary: " + salary);
            Console.WriteLine("Employee Department: " + dept);
        }
    }

    internal class Manager : Employee
    {

        public void hi()
        {
            Console.WriteLine("Hi method called");
        }
    }
}
