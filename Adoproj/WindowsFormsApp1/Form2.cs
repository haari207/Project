using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
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
            string id = textBox1.Text;
            string name=textBox2.Text;
            dateTimePicker1 = new DateTimePicker();
            string address=textBox3.Text;
            string phone=textBox4.Text;

            SqlCommand cmd = new SqlCommand($"insert into customers values '{id}' '{name}' '{dateTimePicker1}' '{address}' '{phone}'", con);

            int r = cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
