using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class indexexception
    {
        public void show()
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5 };
                Console.WriteLine("Enter the index of the array");
                int index = Convert.ToInt32(Console.ReadLine());
                if (index < 0 || index >= arr.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                else
                {
                    Console.WriteLine("The value at index " + index + " is " + arr[index]);
                }


            }
            catch(IndexOutOfRangeException e) {

                Console.WriteLine(e.Message);

            }
            catch(FormatException e)
            {
                Console.WriteLine("Please enter a valid number");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End of program");
            }
        }



    }
}
