using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirstdemo
{
    internal class CodeCRUD
    {
        Model1 ob = new Model1();
        public void Insert()
        {
            Movie m= new Movie();
            m.Movieid = 100;
            m.Moviename = "Baahubali";
            m.Actor = "prabhas";
            m.Actress = "anushka";
            m.YOR = 2015;
            ob.Movies.Add(m);



            int i= ob.SaveChanges();
            Console.WriteLine("Total records inserted is:" +i);
        }


        public void insertipl()
        {

            try
            {
                IPL i = new IPL();
                i.teamid = 100;
                i.Tname = "Sunrisers Hyderabad.....";
                i.Budget = 200000;
                i.state = "Telangana";
                i.cap = "Patcummins";
                ob.IPLs.Add(i);
                int r = ob.SaveChanges();
                Console.WriteLine("Total records inserted is:" + r);
            }
            catch (Exception e)
            {
                var err = ob.GetValidationErrors();
                foreach (var item in err)
                {
                    foreach (var e1 in item.ValidationErrors)
                    {
                        Console.WriteLine(e1.ErrorMessage);
                    }
                }

            }

        }

    }
}
