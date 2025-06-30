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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS");
            SqlDataAdapter da = new SqlDataAdapter("select * from customers", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds, "c");
            dt = ds.Tables["c"];
            DataView dv = new DataView(dt);
            string cond = textBox1.Text.Trim();
            string drop = comboBox1.Text.Trim();
            dv.RowFilter = $"caddress ='{cond}'";
            string sortOrder = drop.Equals("Descending", StringComparison.OrdinalIgnoreCase) ? "DESC" : "ASC";
            dv.Sort = $"cname {sortOrder}";

            dataGridView1.DataSource = dv;
        }
    }
}
