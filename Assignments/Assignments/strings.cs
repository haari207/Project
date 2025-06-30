using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class strings
    {
        string str;
        public void strreverse()
        {
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine("The reversed string is " + new string(arr));
        }

        public void countchar()
        {
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            Console.WriteLine("enter the character:");
            char ch = Convert.ToChar(Console.ReadLine());
            int count = 0;
            foreach (char c in str)
            {
                if (c == ch)
                {
                    count++;
                }
            }
            Console.WriteLine($"The {ch} no. of occurrences in a string is:{count}");
        }
        public void printdetails()
        {
            Console.WriteLine("enter fullname:");
            string fn = Console.ReadLine();
            string fn1 = fn.Split(' ')[0];
            string fn2 = fn.Split(' ')[1];
            Console.WriteLine("The first name is:" + fn1);
            Console.WriteLine("The last name is:" + fn2);
            int count = 0;
            foreach (char c in fn)
            {
                if (c != ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("no of characters in a string excluding spaces:" + count);

        }

        public void comparestr()
        {
            Console.WriteLine("enter  first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter second string:");
            string str2 = Console.ReadLine();
            if (str1.Equals(str2))
            {
                Console.WriteLine("Both strings are equal");
            }
           else if(str1.CompareTo(str2)!=0)
            {
                Console.WriteLine("Both strings are not equal");
            }
        }
    }
}
