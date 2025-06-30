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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sq = new SqlConnectionStringBuilder();

            sq.ConnectionString = "Integrated Security=true";
            sq.DataSource = "WKSBAN36SUHTR04\\SQLEXPRESS";
            sq.InitialCatalog = "b248db";
            sq.MultipleActiveResultSets = true;
            String st = sq.ConnectionString;
            SqlConnection con = new SqlConnection(st);
            con.Open();

            string uid= textBox1.Text;
            string pwd= textBox2.Text;
            SqlCommand cmd = new SqlCommand($"select count(*)  from userlogin1 where userid= '{uid}' and userpassword='{pwd}'",con);

            //runs the query and stores the result in datareader object
           int i=(int) cmd.ExecuteScalar();
            if (i == 1)
            {
                MessageBox.Show("valid user");

            }
            else
            {
                MessageBox.Show("invalid user");
            }
                con.Close();
        }
    }
}
