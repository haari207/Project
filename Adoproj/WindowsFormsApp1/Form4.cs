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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sq = new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            String st = sq.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();
            //SqlCommand cmd = new SqlCommand("insert into customers values(700,'Kavya','2001-05-25','Hyderabad','999184987')",con);

            int id = int.Parse(textBox1.Text);

            string cname = textBox2.Text;

            DateTime DOB = DateTime.Parse(dateTimePicker1.Text);
            string caddress = textBox3.Text;

            string cphone = textBox4.Text;


            string q = "insert into customers values(@id,@name,@dob,@address,@phone)";

            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", cname);
            cmd.Parameters.AddWithValue("@dob", DOB);
            cmd.Parameters.AddWithValue("@address", caddress);
            cmd.Parameters.AddWithValue("@phone", cphone);

            int r = cmd.ExecuteNonQuery();

            if (r == 1)
            {
                MessageBox.Show("inserted row");
            }

            con.Close();
        }
    }
}
