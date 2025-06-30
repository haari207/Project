using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoproj
{
    internal class DisconnectedAdvance
    {
        //Rowstate,Rowversion,Acceptchanges,Rejectchanges

        DataTable dt = new DataTable();
        public void demo1()
        {
            dt.Columns.Add("studid", typeof(int));
            dt.Columns.Add("studname", typeof(string));
            DataRow dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "Pooja";
            Console.WriteLine("not yet attached:" + dr.RowState);//detached state
            dt.Rows.Add(dr);
            Console.WriteLine("added:" + dr.RowState);//added state

            dt.AcceptChanges();//commits all changes to datatable
            Console.WriteLine(dr.RowState);
            dr[1] = "srinivas";
            Console.WriteLine("older value:" + dr[1, DataRowVersion.Original]);
            Console.WriteLine("new value:" + dr[1, DataRowVersion.Current]);

            Console.WriteLine("record modified:" + dr.RowState);
            dr.Delete();
            Console.WriteLine("deleted:" + dr.RowState);
            dt.AcceptChanges();
            Console.WriteLine(dr.RowState);
            dt.RejectChanges();//rollback all changes from datatable

            //foreach (DataRow dr1 in dt.Rows)
            //{
            //    Console.WriteLine(dr[0]);
            //    Console.WriteLine(dr[1]);
            //}

        }
        public void demo2()
        {
            //Dataview ,Rowfilter and Rowstatefilter,sorting views,updating data through views

            SqlConnection con = new SqlConnection("Integrated security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS");
            SqlDataAdapter da = new SqlDataAdapter("select * from customers", con);

            DataSet ds = new DataSet();
            da.Fill(ds, "c");
            dt = ds.Tables["c"];
            // want filter version of dt then go for dataview
            DataView dv = new DataView(dt);
            //dv.RowFilter = "caddress='banglore'";
            //dv.RowFilter = "cid>300 AND cid<800";
            //dv.RowFilter = "cid>300 AND cid<800 or cid=100";

            //dv.RowFilter = "caddress='banglore' AND cname='Hari'";
            //dv.RowFilter = "caddress='delhi' and cname like 'd%'";
            //dv.Sort = "cname";



            //storing the record in data view based on state
            dt.Rows.Add(1000, "sreya", "2000-1-1", "banglore", 984465698);
            dt.Rows.Add(1100, "bhagya", "2003-5-3", "Hyderabad", 82947844);
            //dv.RowStateFilter=DataViewRowState.Added;
            //dt.Rows[0][1] = "harika";
            //dv.RowStateFilter=DataViewRowState.ModifiedCurrent;//prints modified data

            //foreach (DataRowView item in dv)
            //{
            //    Console.WriteLine(item[0]);
            //    Console.WriteLine(item[1]);
            //    Console.WriteLine(item[2]);
            //    Console.WriteLine(item[3]);
            //    Console.WriteLine(item[4]);

            //}
            //dv.RowStateFilter = DataViewRowState.ModifiedOriginal;//prints before modified data
            //foreach (DataRowView item in dv)
            //{
            //    Console.WriteLine(item[0]);
            //    Console.WriteLine(item[1]);
            //    Console.WriteLine(item[2]);
            //    Console.WriteLine(item[3]);
            //    Console.WriteLine(item[4]);

            //}
            dt.Rows[0].Delete();
            dv.RowStateFilter = DataViewRowState.Deleted;
            foreach (DataRowView item in dv)
            {
                Console.WriteLine(item[0]);
                Console.WriteLine(item[1]);
                Console.WriteLine(item[2]);
                Console.WriteLine(item[3]);
                Console.WriteLine(item[4]);

            }
        }


        public void demo3()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS");
            SqlDataAdapter da = new SqlDataAdapter("select * from customers", con);

            DataSet ds = new DataSet();
            da.Fill(ds, "c");
            dt = ds.Tables["c"];
            // want filter version of dt then go for dataview
            DataView dv = new DataView(dt);
            // how to add record from view
            DataRowView dd = dv.AddNew();
            //dd[0] = 1300;
            //dd[1] = "Amitabh";
            //dd[2] = "1-2-1980";
            //dd[3] = "Mumbai";
            //dd[4] = "9837462910";
            //dd.EndEdit(); //done with changes,now update to data table
            dv.Delete(1);
            dt.AcceptChanges();
            foreach (DataRow i in dt.Rows)
            {
                Console.WriteLine(i[0]);
                Console.WriteLine(i[1]);
                Console.WriteLine(i[2]);
                Console.WriteLine(i[3]);
                Console.WriteLine(i[4]);
            }
        }
    }
}