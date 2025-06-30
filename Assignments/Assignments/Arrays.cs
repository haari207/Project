using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Arrays
    {
        public static void common()
        {
            int[] TeamA = { 45, 78, 45, 34, 65, 89 };
            int[] TeamB = { 78, 4, 8, 9, 65, 3, 7, 34 };

            Console.WriteLine("Common elements in both arrays are:");
            var commonElements = TeamA.Intersect(TeamB);

            foreach (var element in commonElements)
            {
                Console.WriteLine(element);
            }
        }

        public static void summultidimension()
        {
            int[,] a = new int[3, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum += a[i, 0];
            }
            Console.WriteLine("Sum of first column: " + sum);
        }


        public static void getdata()
        {
            Object[] myObjects = new Object[5];
            myObjects[0] = "hello";
            myObjects[1] = 123;
            myObjects[2] = 123.4;
            myObjects[3] = "null";
            myObjects[4] = "Mphasis";
            foreach (var obj in myObjects)
            {
                if (obj is string)
                {
                    Console.WriteLine("String: " + obj);
                }

            }
        }
        public static void printnames()
        {
            String[] names = { "Srilanka", "Singapore", "India", "Swedan", "Canada" };
            Console.WriteLine("Names in the array are which starts with s and greater than 7 characters:");
            foreach (var name in names)
            {
                if (name.StartsWith("S") && name.Length > 7)
                {
                    Console.WriteLine(name.ToUpper());
                }
            }

        }

        public static void countevenodd()
        {
            int[] a = { 1, 2, 4, 5, 9, 3, 20, 11 };
            int evencount = 0;
            int oddcount = 0;
            foreach (var num in a)
            {
                if (num % 2 == 0)
                {
                    evencount++;
                }
                else
                {
                    oddcount++;
                }
            }
            Console.WriteLine("Even count: " + evencount);
            Console.WriteLine("Odd count: " + oddcount);

        }

        public static void printduplicates()
        {
            int[] a = { 1, 2, 3, 1, 6, 3, 4, 6, 8, 2 };
            Console.WriteLine("Duplicate elements in the array are:");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        Console.WriteLine(a[i]);
                        break;
                    }
                }
            }
        }

        public static void mergearrays()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length + b.Length];
            Array.Copy(a, c, a.Length);
            Array.Copy(b, 0, c, a.Length, b.Length);
            Console.WriteLine("Merged array:");
        }

        public static void DisplayArray(int[] arr, bool reverse = false)
        {
            if (reverse)
            {
                Array.Reverse(arr);
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void addmatrix()
        {
            int[,] a = { { 1,2},
                          {3,4 } };
            int[,] b = { { 5,6},
                          {7,8 } };
            int[,] c = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];

                }
            }
            Console.WriteLine("Sum of two matrices:");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void sumofmatrix()
        {
            int[,] a = new int[3, 3]
            {
                { 1, 2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            Console.WriteLine(" sum of Matrix elements in each row are:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
               int  sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
                Console.WriteLine("sum of each Row " + (i + 1) + ": " + sum);
            }

        }
        public static void daigonalelements()
        {
            int[,] matrix = {
                   {11, 2, 3},
                   {4, 55, 6},
                    {7, 8, 99}
                };
            Console.WriteLine("Diagonal elements of the matrix are:");
           for (int i=0; i < matrix.GetLength(0); i++)
            {
                for(int j=0;j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }


        }
        public static void Avgofvalues()
        {
            int[][] scores = new int[][] {
            new int[] { 80, 90 },
             new int[] { 70, 85, 90 },
             new int[] { 100 }
            };
            Console.WriteLine("Average of row:");
            for (int i = 0; i < scores.Length; i++)
            {
              int sum = 0;
                for (int j = 0; j < scores[i].Length; j++)
                {
                    sum += scores[i][j];
                }
                var avg = (double)sum / scores[i].Length;
                Console.WriteLine("Avg of each Row " + (i + 1) + ": " + avg);
            }
        }
        public static void longeststr()
        {
            string[] fruits = { "Apple", "Banana", "Watermelon", "Kiwi" };
            Console.WriteLine("Longest string in the array is:");
            if (fruits.Length == 0)
            {
                Console.WriteLine("Array is empty");
                return;
            }
            else
            {
                string max = fruits[0];
                foreach (var fruit in fruits)
                {
                    if (fruit.Length > max.Length)
                    {
                        max = fruit;
                    }
                }
                Console.WriteLine(max);
            }
        }

        public static void joinstr()
        {
            string[] parts = { "2025", "05", "03" };
            string date = string.Join("-", parts);
            Console.WriteLine("Joined string: " + date);
        }

        public static void replacestr()
        {
            string[] techs = {
             "I love Java",
           "Java is versatile",
            "Python is cool"
               };
            Console.WriteLine("Replaced string:");
            foreach (var i in techs)
            {
                Console.WriteLine("" + i.Replace("Java", "C#"));
            }
        }

    }
}

