using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Runtime.Remoting.Messaging;
using System.Data;
namespace Adoproj
{
    internal class Connecteddemo
    {
        public void displaycust()
        { 

            SqlConnectionStringBuilder sq=new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            String st=sq.ConnectionString;
            SqlConnection con=new SqlConnection(st);
            //SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS"); 
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from customers",con);

            //runs the query and stores the result in datareader object
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) //read method always returns bool value
            {
                Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]} {reader[3]} {reader[4]}"); //column index

            }

            con.Close();
        }

        public void insertcust()
        {
            SqlConnectionStringBuilder sq = new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            String st = sq.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();
            //SqlCommand cmd = new SqlCommand("insert into customers values(700,'Kavya','2001-05-25','Hyderabad','999184987')",con);

            Console.Write("Enter Customer ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Date of Birth (yyyy-MM-dd): ");
            string dob = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();


            string q = "insert into customers values(@id,@name,@dob,@address,@phone)";

            SqlCommand cmd = new SqlCommand(q,con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            
            int r = cmd.ExecuteNonQuery();

            Console.WriteLine("Total number of rows inserted is"+r);

            con.Close();
        }
        public void deletcust()
        {
            SqlConnectionStringBuilder sq = new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            String st = sq.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from customers where cid=500", con);
            int r= cmd.ExecuteNonQuery();
            Console.WriteLine("total number of rows effected is:" + r);
            con.Close();


        }
        public void getbyid() {

            SqlConnectionStringBuilder sq = new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            String st = sq.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();

            Console.Write("Enter Customer ID: ");
            int id = int.Parse(Console.ReadLine());
            string q = "select * from customers where cid=@id";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read()) //read method always returns bool value
            {
                Console.WriteLine($"{r[0]} {r[1]} {r[2]} {r[3]} {r[4]}"); //column index

            }

            con.Close();

        }


        public void updatecust() {

            SqlConnectionStringBuilder sq = new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            String st = sq.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();

            Console.Write("Enter Customer ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name:");
            string name= Console.ReadLine();
            string q = "update customers  set cname=@name where cid=@id";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue ("@name", name);
            int r = cmd.ExecuteNonQuery();

            Console.WriteLine("Total number of rows inserted is" + r);

            con.Close();



        }
        public void displaycustproc()
        {

            SqlConnectionStringBuilder sq = new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            String st = sq.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            //SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS"); 
            con.Open();

            SqlCommand cmd = new SqlCommand("getcustomers ", con);
            SqlParameter p = new SqlParameter("@c", "m");
            SqlParameter p1 = new SqlParameter("@a", "Chennai");

            cmd.Parameters.Add(p);//Attaching parameter to cmd procedure
            cmd.Parameters.Add(p1);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;

            //runs the query and stores the result in datareader object
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) //read method always returns bool value
            {
                Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]} {reader[3]} {reader[4]}"); //column index

            }
            con.Close();
        }

        public void displaymultiple()
        {

            SqlConnectionStringBuilder sq = new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            sq.MultipleActiveResultSets = true;
            String st = sq.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from customers;select * from userlogin1", con);

            //runs the query and stores the result in datareader object
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) //read method always returns bool value
            {
                Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]} {reader[3]} {reader[4]}"); //column index

            }
            reader.NextResult();

            while (reader.Read())
            {
                int i;
                i = reader.GetInt32(2);
                Console.WriteLine($"{reader[0]} {reader[1]} {i}");
            }

            con.Close();
        }


    }
}
