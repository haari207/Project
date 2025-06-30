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
using System.Transactions;
namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //first command passes second command fails.
            SqlConnection con = new SqlConnection("Integrated security=true;database=master;server=WKSBAN36SUHTR04\\SQLEXPRESS");
            con.Open();
            SqlCommand cmd=new SqlCommand("insert into TableA values(2,'Ram')",con);
            SqlCommand cmd1 = new SqlCommand("insert into TableB values(1,'Ram')", con);

            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Records inserted successfully.");
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {  //first command passes second command fails.
            SqlTransaction tr = null;
            //all the commands belong to same connection
            try
            {
                SqlConnection con = new SqlConnection("Integrated security=true;database=master;server=WKSBAN36SUHTR04\\SQLEXPRESS");
                con.Open();
                tr = con.BeginTransaction(); //begin transaction   ,all the commands using con as a connection                                         
                SqlCommand cmd = new SqlCommand("insert into TableA values(2,'Ram')", con,tr);
                //cmd.Transaction = tr;           //assigning transaction to command
                cmd.ExecuteNonQuery();
                tr.Save("hi");                    //savepoint is used to rollback to a specific point in the transaction

                SqlCommand cmd1 = new SqlCommand("insert into TableB values(1,'Ram')", con,tr);
                //cmd1.Transaction = tr;          //this 2 commands participating will participate transactions
                cmd1.ExecuteNonQuery();
                tr.Commit();
                MessageBox.Show("Records inserted successfully.");
                con.Close();
            }
            catch (Exception ee)
            {
                tr.Rollback("hi"); //rollback is used to rollback the transaction to a specific point or to the beginning of the transaction
                tr.Commit(); //commit is used to save the changes made in the transaction
                MessageBox.Show("Transaction rollbacked due to error: " + ee.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    using (SqlConnection con = new SqlConnection("Integrated security=true;database=master;server=WKSBAN36SUHTR04\\SQLEXPRESS"))
                    {

                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("insert into TableA values(2,'Ram')", con))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        using (SqlCommand cmd1 = new SqlCommand("insert into TableB values(1,'Ram')", con))
                        {
                            cmd1.ExecuteNonQuery();

                        }
                        ts.Complete(); //Complete is used to commit the transaction
                        MessageBox.Show("Records inserted successfully using TransactionScope.");
                    }
                }// TransactionScope is disposed here, which will commit the transaction if ts.Complete() was called
            }
            catch(Exception ex)
            {
                MessageBox.Show("transaction rollbacked");
            }
        }
    }
}
