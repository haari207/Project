using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mywinapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c=int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            MessageBox.Show(c.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
            {
                label3.Text = textBox1.Text + " is greatest";
            }
            else
            {
                label3.Text = textBox2.Text + "is greatest";
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2_Click(sender, e);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("pls enter number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) % 2 == 0)
            {
                MessageBox.Show("even");
            }
            else
            {
                MessageBox.Show("odd");
            }
        }
    }
}
