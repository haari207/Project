using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        BindingManagerBase bm;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bm.Position = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bm.Position += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bm.Position -= 1;
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
    }
}
