using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class Arraydemo
    {
        private static object console;

        public static void singledimension()
        {
            int[] a = { 10, 20, 70, 30, 40, 50 };
            Console.WriteLine(a[2]);
            Console.WriteLine(a.Length);
            Array.Sort(a);//sorts the array in ascending order
            Array.Reverse(a);//reverses the array and sorts in descinding order
            Console.WriteLine(a.Rank);
            //how to proint all item for array

            foreach (int i in a) //it only reads the data and non indexed and it will read whole array
            {
                Console.WriteLine(i);
            }
        }
        public static void singledimension2()
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++) //read and write ,indexed
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("===============");
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

        }
        public static void multidimension()
        {
            int[,] a =
            {
              {10,20,30,40},
              {50,60,70,80},
              {90,100,110,120}
            };
            Console.WriteLine(a[1, 2]);
            Console.WriteLine(a.Length);//total no. of items
            //how to find length of rows
            //Console.WriteLine(a.GetLength(0));
            //Console.WriteLine(a.GetLength(1));
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a[i, j]);
            //    }
            //}
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

        }
        public static void multidimension2()
        {
            int[,] a = new int[2, 3];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("===============");
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
        }
        public static void jaggedarray()
        {
            int[][] a = new int[5][];
            a[0] = new int[3] { 1, 2, 3 };
            a[1] = new int[2] { 4, 5 };
            a[2] = new int[5] { 6, 7, 8, 9, 10 };
            a[3] = new int[0] { };
            a[4] = new int[1] { 11 };

            foreach (var i in a)
            {
                foreach (var j in i)
                {
                    Console.WriteLine(j);
                }
            }
        }
        public static void boxingdemo()
        {

            int a = 10;
            object b = a; //boxing
            Console.WriteLine(b);

            int c = (int)b; //unboxing
            Console.WriteLine(c);
        }
        public static void nullabledemo()
        {
            int? a = null;
            //int b = 10;
            //int c = a ?? b; //null coalescing operator
            Console.WriteLine(a.HasValue);
            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }
            else
            {
                Console.WriteLine("a is null");
            }

        }
        public unsafe static void unsafecode()
        {
            int a = 10;
            int* p = &a; //pointer
            Console.WriteLine(*p);


        }
    }
}
