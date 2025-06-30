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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable(); //customers
        DataTable dt1 = new DataTable(); //orders table
        SqlDataAdapter da;
        SqlDataAdapter da1;
        private void Form8_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=b248db;server=WKSBAN36SUHTR04\\SQLEXPRESS");
            da = new SqlDataAdapter("select * from customers", con);
            da1 = new SqlDataAdapter("select * from orders", con);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;//using this we are adding keys to the datatable 
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da1.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder cm1 = new SqlCommandBuilder(da1);
            da.Fill(ds, "c");
            da1.Fill(ds, "o");
            dt = ds.Tables["c"];
            dt1 = ds.Tables["o"];
            DataRelation drr = new DataRelation("custord", dt.Columns[0], dt1.Columns[1]);
            ds.Relations.Add(drr); //parent-child relationship

            ds.Relations["custord"].ChildKeyConstraint.DeleteRule = Rule.Cascade; //if parent record is deleted then child record will also be deleted

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "cid";
            UniqueConstraint u = new UniqueConstraint(dt.Columns[4]);
            dt.Constraints.Add(u);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt1;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.Update(dt);
            da1.Update(dt1);
            MessageBox.Show("Record updated");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dt.Rows.Count)
            {
                DataRow dr = dt.Rows[e.RowIndex];
                comboBox1.SelectedValue = dr["cid"];
            }
            else
            {
                MessageBox.Show("Invalid row index selected.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRow[] d = dt.Rows[comboBox1.SelectedIndex].GetChildRows("custord");
            DataTable temp = dt1.Clone();
            foreach (var dr in d)
            {
                temp.ImportRow(dr);

            }
            dataGridView2.DataSource=temp;
        }
    }
}
