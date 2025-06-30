using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class Day1Assignment
    {
        public static void greatest3()
        {
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine($"The greatest number is {a} among {b} and {c}");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"The greatest number is {b}  among {a} and {c}");
            }
            else
            {
                Console.WriteLine($"The greatest number is {c} among {a} and {b}");
            }

        }

        public static void empdetails()
        {

            Console.WriteLine("Enter employee name:");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter employee salary");
            int salary = int.Parse(Console.ReadLine());
            int HRA = (int)(0.15 * salary);
            int DA = (int)(0.1 * salary);
            int Grosspay = HRA + DA + salary;
            int Tax = (int)(0.08 * Grosspay);
            Console.WriteLine("The HRA is:" + HRA);
            Console.WriteLine("The DA is:" + DA);
            Console.WriteLine("The grosspay is:" + Grosspay);
            Console.WriteLine("The Tax is:" + Tax);
            Console.WriteLine("Employee name is:" + empname);
            Console.WriteLine("The employee salary:" + salary);
        }
        public static void factorial()
        {
            Console.WriteLine("enter a number");
            string input = Console.ReadLine();

            int number;

            if (input == "")
            {
                number = 5;
            }
            else
            {
                number = int.Parse(input);
            }
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"factorial of {number} is:{fact}");
        }
        public static void sumof10nums()
        {

            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"enter number {i}:");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Negative numbers are not allowed");
                    break;
                }
                sum += number;
            }
            Console.WriteLine($"The sum of  10 natural numbers:{sum}");
        }
        public static void swapnum()
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After Swap: a = {a}, b = {b}");
        }

        public static void copystr()
        {
            Console.WriteLine("Enter a string:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter a string:");
            string b = Console.ReadLine();

            string c = a + b;
            Console.WriteLine($"The concatenated string is {c}");
        }
        public static void divnums()
        {
            Console.WriteLine("Enter the first number (dividend):");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number (divisor):");
            int divisor = int.Parse(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return;
            }

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
        }

        public static void printnames()
        {
            Console.WriteLine("enter number:");
            int n=int.Parse(Console.ReadLine());    
            Console.WriteLine("Enter name:");
            string name= Console.ReadLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Name {i}: {name}");
            }
        }
    }
        }
