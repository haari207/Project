using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class PersonCls
    {
        public string firstname  { get; set; }
        public string lastname { get; set; }

        public DateTime dateofbirth { get; set; }

        public PersonCls()
        {
            Console.WriteLine("Enter first name");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter last name");
            lastname = Console.ReadLine();
            Console.WriteLine("Enter date of birth");
            dateofbirth = Convert.ToDateTime(Console.ReadLine());
        }
        public void printdetails()
        {
            Console.WriteLine("checking whether or not today is persons birthday");
            DateTime today = DateTime.Today;
            Console.WriteLine("Date of Birth: " + dateofbirth.ToShortDateString());
            if (today.Month == dateofbirth.Month && today.Day == dateofbirth.Day)
            {
                Console.WriteLine("Today is the person's birthday.");
            }
            else
            {
                Console.WriteLine("Today is not the person's birthday.");
            }

            Console.WriteLine("checking whether or not person is over 18");

            if(today.Year - dateofbirth.Year > 18)
            {
                Console.WriteLine("Person is over 18");
            }
            else
            {
                Console.WriteLine("Person is not over 18");
            }






        }


    }
}
