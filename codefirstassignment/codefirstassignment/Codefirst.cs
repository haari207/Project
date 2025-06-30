using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstassignment
{
    public class Codefirst
    {

        Model1 ob= new Model1();
        internal object ob1;

        public void AddEmployee()
        {
           
           
                Console.WriteLine("Enter Employee ID (format: E123):");
                string empid = Console.ReadLine();
                Console.WriteLine("enter Employee Name:");
                string empname = Console.ReadLine();
                Console.WriteLine("Department id:");
                int deptid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Salary (between 50000 and 150000):");
                int salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Date of Birth (format: yyyy-mm-dd):");
                DateTime dob = DateTime.Parse(Console.ReadLine());
                Employee emp = new Employee
                {
                    Empid = empid,
                    EmpName = empname,
                    Deptid = deptid,
                    salary = salary,
                    DOB = dob
                };
            try
            {
                ob.Employees.Add(emp);
                int r = ob.SaveChanges();
                Console.WriteLine("total rows inserted is:" + r);
            }
            catch(DbEntityValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }


        public void Adddept()
        {

            
                Console.WriteLine("Enter Department ID:");
                int deptid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Department Name:");
                string deptName = Console.ReadLine();
                Console.WriteLine("Enter manager name");
                string manager = Console.ReadLine();
                department dept = new department
                {
                    Deptid = deptid,
                    DeptName = deptName,
                    Manager = manager
                };
                ob.departments.Add(dept);
                int r = ob.SaveChanges();
                Console.WriteLine("total rows inserted is:" + r);
            
        }
    }
}
