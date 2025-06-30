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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                errorProvider1.SetError(textBox1, "please enter a username"); 
            }
            else
            {
                errorProvider1.Clear();
            }
            if(textBox2.Text.Length != 0)
            {
                errorProvider1.SetError(textBox2, "password not matched");
            }
           
            string result = textBox1.Text + "\n";
            result += textBox2.Text + "\n";
            if (radioButton1.Checked)
            {
                result += radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                result += radioButton2.Text;
            }
            if (checkBox1.Checked)
            {
                result += checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                result += checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                result += checkBox3.Text;
            }
            result += dateTimePicker1.Text + "\n";
            result += comboBox1.Text + "\n";
            result += listBox1.Text + "\n";
            label8.Text = result;
            string s = "";
            foreach (var item in s)
            {
                s += item.ToString() + "\n";
            }
      
        }

       
    }
}
