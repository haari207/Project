using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student5[] students = new student5[5];
            students[0] = new student5() { studentid = 1, studentname = "John", marks = new int[] { 40, 50, 50, 60 } };
            students[1] = new student5() { studentid = 2, studentname = "Doe", marks = new int[] { 70, 80, 90, 100 } };
            students[2] = new student5() { studentid = 3, studentname = "Smith", marks = new int[] { 20, 30, 40, 50 } };
            students[3] = new student5() { studentid = 4, studentname = "Jane", marks = new int[] { 60, 70, 80, 90 } };
            students[4] = new student5() { studentid = 5, studentname = "Doe", marks = new int[] { 50, 60, 70, 80 } };
            #region
            //Arrays.common();
            //Arrays.summultidimension();
            //Arrays.getdata();
            //Arrays.printnames();
            //Arrays.countevenodd();
            //Arrays.printduplicates();
            //Arrays.mergearrays();
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Arrays.DisplayArray( arr,true);
            //Arrays.addmatrix();
            //Arrays.sumofmatrix();
            //Arrays.daigonalelements();
            //Arrays.Avgofvalues();
            //Arrays.longeststr();
            //Arrays.joinstr();
            //Arrays.replacestr();
            //Movies m=new Movies() { Actor = "Prabhas", Actress = "Anushka", movieId = 1, Moviename = "Mirchi" };
            //Movies m1= new Movies() { Actor = "NTR", Actress = "Samantha", movieId = 2, Moviename = "Janatha Garage" };
            //m.showdetails();
            //m1.showdetails();
            //car c = new car() { carname = "BMW", carcolor = "Black", carmodel = "X5", carbrand = "BMW", carprice = 1000000 };
            //car c1 = new car() { carname = "Audi", carcolor = "White", carmodel = "Q7", carbrand = "Audi", carprice = 2000000 };
            //car c2 = new car() { carname = "Mercedes", carcolor = "Red", carmodel = "Benz", carbrand = "Mercedes", carprice = 3000000 };
            //c.displaycardetails();
            //Console.WriteLine("================");

            //c1.displaycardetails();
            //Console.WriteLine("================");

            //c2.displaycardetails();

            //Team t = new Team() { Teamid = 1, Teamnames = new string[]{ "India", "Australia", "England" } };
            //Team t1 = new Team() { Teamid = 2, Teamnames = new string[] { "SRH", "RCB", "CSK" } };
            //t.printteamdetails();
            //t1.printteamdetails();

            //Students s = new Students() { studid = 1, studname = "John", Marks = 20 };
            //Students s1 = new Students() { studid = 2, studname = "Doe", Marks = 70 };
            //Students s2 = new Students() { studid = 3, studname = "Smith", Marks = 50 };
            //s.getdetails();
            //Console.WriteLine("================");
            //s1.getdetails();
            //Console.WriteLine("================");
            //s2.getdetails();

            //foreach (var student in students)
            //{
            //  student.getdetails();
            //    Console.WriteLine("================");
            //}

            //Console.WriteLine("enter id :");
            //int id=int.Parse(Console.ReadLine());
            //student5.getbyid(students, id);

            //Console.WriteLine("First class students are:");
            //foreach (var student in students)
            //{
            //    student.getfirstclassdata();

            //}
            // c ob= new c();
            //ob.Hello();
            //ob.first();
            //ob.Hi();
            //Console.WriteLine($"Name  YearofJoining   Address ");
            //Employee e = new Employee() { Name= "john",yearofjoining= 2020,  Address = " Hyderabad" };
            //Employee e1 = new Employee() { Name = "Doe", yearofjoining = 2021, Address = " Bangalore" };
            //Employee e2 = new Employee() { Name = "Smith", yearofjoining = 2022, Address = " Chennai" };
            //e.displaydetails();
            //e1.displaydetails();
            //e2.displaydetails();

            //PersonCls p = new PersonCls();
            //p.printdetails();
            //derived d= new derived(10);
            //Animal a =new Animal();
            //a.makesound();
            //Console.WriteLine("==================================");
            //a = new dog();
            //a.makesound();
            //Console.WriteLine("==================================");
            //a = new cat();
            //a.makesound();
            //manager m = new manager() { name = "John", age = 30, salary = 50000, bonus = 10000 };
            //Console.WriteLine($"Name: {m.name}, Age: {m.age}, Salary: {m.salary}, Bonus: {m.bonus}");
            //Vehicle v = new Vehicle();
            //v.drive();
            //v = new Car();
            //v.drive();
            //v = new Bike();
            //v.drive();
            //Ishape a=new circle(10);
            //Console.WriteLine("Area of circle is:" + a.calculatearea());
            //a = new Rectangle(5, 10);           
            //Console.WriteLine("Area of rectangle is:" + a.calculatearea());
            #endregion
            //tuple t = new tuple();
            //var t1=t.splitfullname("John Doe");
            //Console.WriteLine(t1.Item1);
            //Console.WriteLine(t1.Item2);
            //Employee e = new Employee() { Empname = "John", salary = 50000, dept = "IT" };
            //e.Getdetails();
            //Manager m = new Manager();
            //m.hi();

            //string s = "students";
            //char c = 's';
            //Console.WriteLine("no. of occurrences in a string :" +s.CountOccurrences(c));

            //Console.WriteLine("Enter the number of elements in the array:");
            //int n = int.Parse(Console.ReadLine());

            //int[] a = new int[n];
            //Console.WriteLine("Enter the elements of the array:");

            //Console.WriteLine("no of even count in a array :" +a.checkEvenCount());

            //indexexception ob = new indexexception();
            //ob.show();
            strings s=new strings();
            //s.strreverse();
            //s.countchar();
            //s.printdetails();
            s.comparestr();
            Console.Read();
            
        }
    }
}
