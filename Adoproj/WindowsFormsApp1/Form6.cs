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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startdate = DateTime.Parse(dateTimePicker1.Text);

            DateTime enddate = DateTime.Parse(dateTimePicker2.Text);


               SqlConnection con = new SqlConnection("Data Source=WKSBAN36SUHTR04\\SQLEXPRESS;Initial Catalog=b248db;Integrated Security=True");
            
               SqlCommand cmd = new SqlCommand("SELECT * FROM customers WHERE dob BETWEEN @start AND @end", con);
                
                    cmd.Parameters.AddWithValue("@start", startdate);
                    cmd.Parameters.AddWithValue("@end", enddate);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

            }
        }
    }

