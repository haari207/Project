using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFpatterns
{
    internal abstract class Template
    {
        public void processdata()
        {
            selectbook();
            makepayment();
            deliver();
        }
        public abstract void selectbook();
        public abstract void makepayment();

        public abstract void deliver();

    }

    class online: Template
    {
        public override void selectbook()
        {
            Console.WriteLine("Select book from online store");
        }
        public override void makepayment()
        {
            Console.WriteLine("Make payment online");
        }
        public override void deliver()
        {
            Console.WriteLine("Deliver book to home address");
        }
    }
    class physicaldelivery : Template
    {
        public override void selectbook()
        {
            Console.WriteLine("Select book from physical store");
        }
        public override void makepayment()
        {
            Console.WriteLine("Make payment in upi");
        }
        public override void deliver()
        {
            Console.WriteLine("Deliver a physical book to home address");
        }
    }
}
