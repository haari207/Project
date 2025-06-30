using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyconsoleApp
{
    internal class disposable:IDisposable
    {

        public disposable()
        {
            Console.WriteLine("database established");
            Console.WriteLine("constructor");
        }
        public void add()
        {
            Console.WriteLine("read from database");
            Console.WriteLine("Add called");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("object destroyed");
            Console.WriteLine("database connection is closed");
        }

        public void sub()
        {
            Console.WriteLine("delete from database");
            Console.WriteLine("Sub called");
        }
        ~disposable()
        {
            Console.WriteLine("destructor");
        }

    }
}
