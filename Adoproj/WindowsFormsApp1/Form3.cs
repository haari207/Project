using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sq = new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            String st = sq.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            //SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS"); 
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from customers", con);

            //runs the query and stores the result in datareader object
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[1]);
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<cust> li= new List<cust>();
            SqlConnectionStringBuilder sq = new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            String st = sq.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            //SqlConnection con = new SqlConnection("Integrated Security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS"); 
            con.Open();

            SqlCommand cmd = new SqlCommand($"select * from customers where cname='{comboBox1.Text}'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                li.Add(new cust() {cid = dr.GetInt32(0),cname = dr.GetString(1),DOB = dr.GetDateTime(2),caddress = dr.GetString(3),cphone = dr.GetString(4)});
            }
            dataGridView1.DataSource = li;

        }
    }
    class cust
    {
        public int cid { get; set; }
        public string cname { get; set; }
        public  DateTime DOB { get; set; }
        public string caddress { get; set; }
        public string cphone { get; set; }

    }
}
