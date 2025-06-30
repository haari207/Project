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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable(); //customers
        SqlDataAdapter da;
        BindingManagerBase bm; //anytime we want to navigate like next previous we use this class
        private void Form9_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS");
            da = new SqlDataAdapter("select * from customers", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;//using this we are adding keys to the datatable 
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Fill(ds, "c");
            dt = ds.Tables["c"];
            textBox1.DataBindings.Add("Text", dt, "cid");
            textBox2.DataBindings.Add("Text", dt, "cname");
            textBox3.DataBindings.Add("Text", dt, "DOB");
            textBox4.DataBindings.Add("Text", dt, "caddress");
            textBox5.DataBindings.Add("Text", dt, "cphone");
            bm = BindingContext[dt]; //BindingContext is a collection of BindingManagerBase objects
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bm.Position += 1; //next record
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bm.Position -= 1; //previous record
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count - 1; //last record
            if (bm.Count == 0)
            {
                MessageBox.Show("No records found in the database.");
            }
            else
            {
                MessageBox.Show("Last record displayed.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string val = textBox6.Text;
            DataRow[] rows = dt.Select("cid='" + val + "'"); //selecting rows based on cname
            foreach (DataRow row in rows)
            {
                textBox1.Text = row["cid"].ToString();
                textBox2.Text = row["cname"].ToString();
                textBox3.Text = row["DOB"].ToString();
                textBox4.Text = row["caddress"].ToString();
                textBox5.Text = row["cphone"].ToString();

            }
        }
    }
}
