using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Runtime.Remoting.Messaging;
namespace Adoproj
{
    internal class Disconnecteddemo
    {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            SqlDataAdapter da;
        public void displaycustomer()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS");
            da= new SqlDataAdapter("select * from customers", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;//using this we are adding keys to the datatable 
            SqlCommandBuilder cm=new SqlCommandBuilder(da);
            da.Fill(ds, "c");
            dt = ds.Tables["c"];
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Console.WriteLine(dt.Rows[i][0]);
                Console.WriteLine(dt.Rows[i][1]);
                Console.WriteLine(dt.Rows[i][2]);
                Console.WriteLine(dt.Rows[i][3]);
                Console.WriteLine(dt.Rows[i][4]);
                Console.WriteLine("===============");

            }
        }
        public void insert()
        {
            //all CRUD operations are done by data table only
            //ur trying to insert record to data table which is local copy will not update to db
            dt.Rows.Add(900,"Akshu","2003-03-25","kerala","9897473846");
            int d=da.Update(dt); //it will update the changes to db
            Console.WriteLine("total rows inserted is:"+d);  
        }
        public void update()
        {

            Console.WriteLine("enter id:");
            int id = int.Parse(Console.ReadLine());
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            DataRow dr = dt.Rows.Find(id);
            dr[1] = "vidhya";

             int i = da.Update(dt);
            Console.WriteLine("Total rows updated is:" + i);
        }

        public void delete()
        {

            Console.WriteLine("enter id:");
            int id = int.Parse(Console.ReadLine());
           // dt.PrimaryKey = new DataColumn[] { dt.Columns[0] }; 
            DataRow dr = dt.Rows.Find(id);
            Console.WriteLine(dr[0]);
            Console.WriteLine(dr[1]);
            Console.WriteLine(dr[2]);
            Console.WriteLine(dr[3]);
            Console.WriteLine(dr[4]);
            dr.Delete();
            int i = da.Update(dt);
            Console.WriteLine("Total rows deleted is:"+i);
        }

        public void search()
        {
            Console.WriteLine("enter id:");
            int id = int.Parse(Console.ReadLine());
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };  //it is another method to add keys and arraytype is used if we have composite keys it should work.
            DataRow dr = dt.Rows.Find(id); //find method requires always a primary key if not it will not work

            if (dr == null)
            {
                Console.WriteLine("id not found");
            }
            else
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2]);
                Console.WriteLine(dr[3]);
                Console.WriteLine(dr[4]);
            }
        }

        public void generatexml()
        {    // creates xml file and stores all dataset records to xml in case db is not available
            ds.WriteXml("C:\\Students\\students1.xml");
            Console.WriteLine("created");
        }
        public void generatexmlwithchanges()
        {

            DataRow dr = dt.Rows.Find(100);
            dr[1] = "Harika";
            DataRow dr1 = dt.Rows.Find(600);
            dr1.Delete();
            //ds.WriteXml("C:\\Students\\students2.xml",XmlWriteMode.WriteSchema);
            ds.WriteXml("C:\\Students\\students2.xml", XmlWriteMode.DiffGram);

            Console.WriteLine("created");
        }

        public void getchanges()
        {
            DataRow dr=dt.Rows.Find(200);
            dr[1] = "Rajini";
            DataRow dr1=dt.Rows.Find(600);
            dr1[1] = "Meena";
            if (ds.HasChanges())
            {
                DataSet ds1 = ds.GetChanges();
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++) {
                    Console.WriteLine(ds1.Tables[0].Rows[i][0]);
                    Console.WriteLine(ds1.Tables[0].Rows[i][1]);
                    Console.WriteLine(ds1.Tables[0].Rows[i][2]);
                    Console.WriteLine(ds1.Tables[0].Rows[i][3]);
                    Console.WriteLine(ds1.Tables[0].Rows[i][4]);

                }
              
            }

            else
            {
                Console.WriteLine("No changes in record");
            }
        }

    public void convertreadertotable()
        {
            DataTable dt1=new DataTable();
            //reader to datatable
            // how to read data from data reader pulling from data table
            SqlConnectionStringBuilder sq = new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            String st = sq.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from customers", con);

            SqlDataReader dr = cmd.ExecuteReader();

            dt1.Load(dr);
            con.Close();

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                Console.WriteLine(dt1.Rows[i][0]);
                Console.WriteLine(dt1.Rows[i][1]);
                Console.WriteLine(dt1.Rows[i][2]);
                Console.WriteLine(dt1.Rows[i][3]);
                Console.WriteLine(dt1.Rows[i][4]);
                Console.WriteLine("===============");

            }

        }
        public void readonlytable()
        {

            // how to make datatable readonly

            //datatable to reader
            DataTableReader dtr = new DataTableReader(dt);

            //dt is read nd write where dtr is read only

            while (dtr.Read()) //read method always returns bool value
            {
                Console.WriteLine($"{dtr[0]} {dtr[1]} {dtr[2]} {dtr[3]} {dtr[4]}"); 

            }
        }
        public void copy()
        {
            DataSet ds2=new DataSet();
            SqlConnection con = new SqlConnection("Integrated security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS");
            da = new SqlDataAdapter("select * from customers", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;//using this we are adding keys to the datatable 
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Fill(ds, "c");
            ds2 = ds.Copy();
            dt = ds2.Tables["c"];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i][0]);
                Console.WriteLine(dt.Rows[i][1]);
                Console.WriteLine(dt.Rows[i][2]);
                Console.WriteLine(dt.Rows[i][3]);
                Console.WriteLine(dt.Rows[i][4]);
                Console.WriteLine("===============");

            }
        }

        public void merge()
        {
            DataSet ds2 = new DataSet();
            DataSet ds3= new DataSet();       

            SqlConnection con = new SqlConnection("Integrated security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS");
            da = new SqlDataAdapter("select * from customers", con);
           SqlDataAdapter da1=new SqlDataAdapter("select * from userlogin1",con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;//using this we are adding keys to the datatable 
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            SqlCommandBuilder cm2=new SqlCommandBuilder(da1);
            da.Fill(ds, "c");
            da1.Fill(ds2, "u");
            ds3.Merge(ds);
            ds3.Merge(ds2);
            dt=ds3.Tables["c"];
            for (int i = 0;i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i][0]);
                Console.WriteLine(dt.Rows[i][1]);
                Console.WriteLine(dt.Rows[i][2]);
                Console.WriteLine(dt.Rows[i][3]);
                Console.WriteLine(dt.Rows[i][4]);
                Console.WriteLine("===============");
            }
            dt=ds3.Tables["u"];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i][0]);
                Console.WriteLine(dt.Rows[i][1]);

            }
        }
        }
    }




  
