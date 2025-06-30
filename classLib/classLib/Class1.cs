using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLib
{

    public interface Icustomer
    {


        void show();

    }
    public class Class1
    {
        Model2Container ob=new Model2Container();
        public void Add(Customer cust)
        {
            ob.Customers.Add(cust);
            ob.SaveChanges();
        } 
       public int delete(int id)
        {
            Customer cust = ob.Customers.Find(id);
            if (cust != null)
            {
                ob.Customers.Remove(cust);
                return ob.SaveChanges();
            }
            return 0;
        }
        public Customer searchbyid(int id)
        {
            ob.Customers.Find(id);
            return ob.Customers.Find(id);
        }
        public List<Customer> display()
        {
            return ob.Customers.ToList();
        }

       
    }
}
