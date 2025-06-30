using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal  static class Extensions
    {

        public static int  CountOccurrences(this string str, char character)
        {
            return str.Count(c => c == character);
        }

        public static int checkEvenCount(this int[] x)
        {
            int count = 0;
            for (int i=0;i < x.Length; i++)           
            {
              x[i]=int.Parse(Console.ReadLine());
            }
            foreach (var i in x)
            {
                Console.WriteLine(i);
            }
            foreach (var i in x)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
       
    }
 }

