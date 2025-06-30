using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFpatterns
{
    internal class login { 

        public void checkuser()
        {
            Console.WriteLine("login method called");
        }

    }
    internal class product
    {
        public void addproduct()
        {
            Console.WriteLine("Product added");
        }


    }
    internal class makepayment
    {
        public void processpayment()
        {
            Console.WriteLine("Payment processed");
        }



    }
    internal class sendmail
    {
        public void mailtouser()
        {
            Console.WriteLine("Mail sent to user");
        }
    }
        class faced
        {
            login l;
            product p;
            makepayment m;
            sendmail s;
            public faced()
            {
                l = new login();
                p = new product();
                m = new makepayment();
                s = new sendmail();
            }
            public void buyproduct()
            {
                l.checkuser();
                p.addproduct();
                m.processpayment();
                s.mailtouser();
            }
        }

    }

