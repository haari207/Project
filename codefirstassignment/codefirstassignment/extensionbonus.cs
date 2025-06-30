using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace codefirstassignment
{
    internal static class extensionbonus
    {
        public static double bonus(this Codefirst c, double x)
        {
            Model1 model=new Model1();
            double bonus = 0;
            foreach (var emp in model.Employees)
            {
                bonus = emp.salary * x;
                Console.WriteLine("Bonus (30% of Salary): " + bonus);
            }
            return bonus;
        }

       
    }
}
