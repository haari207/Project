using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable(); //customers
        SqlDataAdapter da;
        SqlCommand sq = new SqlCommand();

        private void Form11_Load(object sender, EventArgs e)
        {
            //this is used to check concurrency, if cname is not equal to ocuname then it will not update the record

            SqlConnection con = new SqlConnection("Integrated security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS");
            da = new SqlDataAdapter("select * from customers", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;//using this we are adding keys to the datatable 
            //SqlCommandBuilder cm = new SqlCommandBuilder(da);
            sq.Connection = con;
            da.Fill(ds, "c");
            dt = ds.Tables["c"];
            dataGridView1.DataSource = dt; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "update customers set cname=@cname where cid=@cid and cname=@ocname";

            try
            {

                SqlParameter p1 = new SqlParameter("@cid", SqlDbType.Int, 4, "cid");
                SqlParameter p2 = new SqlParameter("@cname", SqlDbType.VarChar, 20, "cname");
                SqlParameter p3 = new SqlParameter("@ocid", SqlDbType.Int, 4, "cid");
                p3.SourceVersion = DataRowVersion.Original; //this is used to get the original value of cname before update
                SqlParameter p4 = new SqlParameter("@ocname", SqlDbType.VarChar, 20, "cname");
                p4.SourceVersion = DataRowVersion.Original;

                sq.Parameters.Add(p1);
                sq.Parameters.Add(p2);
                sq.Parameters.Add(p3);
                sq.Parameters.Add(p4);
                sq.CommandText=query;
                da.UpdateCommand = sq;
               
                da.Update(dt);
                MessageBox.Show("record updated successfully");
            }
            catch(DBConcurrencyException ex)
            {
                MessageBox.Show("Record already modified");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "update customers set cname=@cname,caddress=@caddress where cid=@cid and ts=@ots";

            try
            {

                SqlParameter p1 = new SqlParameter("@cid", SqlDbType.Int, 4, "cid");
                SqlParameter p2 = new SqlParameter("@cname", SqlDbType.VarChar, 20, "cname");
                SqlParameter p3 = new SqlParameter("@caddress", SqlDbType.VarChar, 20, "caddress");
                p3.SourceVersion = DataRowVersion.Original; //this is used to get the original value of cname before update
                SqlParameter p4 = new SqlParameter("@ots", SqlDbType.Timestamp, 8, "ts");
                p4.SourceVersion = DataRowVersion.Original;
                sq.Parameters.Add(p1);
                sq.Parameters.Add(p2);
                sq.Parameters.Add(p3);
                sq.Parameters.Add(p4);
                sq.CommandText = query;
                da.UpdateCommand = sq;

                da.Update(dt);
                MessageBox.Show("record updated successfully");
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Record already modified");
            }

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
