


namespace MyclassLib
{
    public class MyClass
    {

        public int Addnums(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Greatest(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;

        }

        public int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        public int[] sumofarrays()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return array;


        }

        public int sumofarrays(int[] a, int[] b)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                sum += b[i];
            }
            return sum;


        }
        public int divide(int a, int b)
        {
            try
            {
                return a / b;
            }

            catch (Exception e)
            {

                throw new DivideByZeroException("Denominator cannot be zero");
            }
        }
    }
}
