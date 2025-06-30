using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Genrepo
    {

        b248dbEntities ob = new b248dbEntities();
        public void Insert<T>(T t) where T : class
        {
            ob.Set<T>().Add(t);
            int r = ob.SaveChanges();
            Console.WriteLine("Total records inserted are:" + r);

        }
        public void delete<T>(T t) where T : class
        {
            ob.Set<T>().Attach(t);
            ob.Set<T>().Remove(t);
            int r = ob.SaveChanges();
            Console.WriteLine("Total records deleted are:" + r);
        }
        public T Find<T>(int t) where T : class
        {
           return  ob.Set<T>().Find(t);
        }
        //create generic function to return top 3 records 
        public IQueryable<T> Top3<T>(int t) where T : class
        {
            return ob.Set<T>().Take(t);
        }
    }
}
