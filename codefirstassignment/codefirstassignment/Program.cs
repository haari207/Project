using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Codefirst ob= new Codefirst();
           
           Model1 ob1= new Model1();


            try
            {
                //ob.Adddept();
                //ob.AddEmployee();
                ob.bonus(0.3);

            }
            catch (Exception ex)
            {
                var err = ob1.GetValidationErrors();
                foreach (var item in err)
                {
                    foreach (var e1 in item.ValidationErrors)
                    {
                        Console.WriteLine(e1.ErrorMessage);
                    }
                }

            }
            

            Console.Read();








        }
    }
}
