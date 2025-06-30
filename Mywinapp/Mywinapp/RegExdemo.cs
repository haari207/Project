using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Mywinapp
{
    public partial class RegExdemo : Form
    {
        public RegExdemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ONLY NUMBER
            var res = Regex.IsMatch(textBox1.Text, "^[0-9]+$");
            label1.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var res = Regex.IsMatch(textBox1.Text, "^[a-zA-Z]+$");
            label1.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // No white spaces
            var res = Regex.IsMatch(textBox1.Text, "^\\S+$");
            label1.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var res = Regex.IsMatch(textBox1.Text, "^[a-zA-Z0-9]+$");
            label1.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var res = Regex.Match(textBox1.Text, @"\d+");
            if (res.Success)
            {
                label1.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("no such pattern");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var res = Regex.Matches(textBox1.Text, @"\d+");
            foreach (Match match in res)
            {
                if (match.Success)
                {
                    label1.Text += match.ToString();
                }
                else
                {

                    MessageBox.Show("no such pattern");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var res = Regex.IsMatch(textBox1.Text, "^[a-z]{3,4}$",RegexOptions.IgnoreCase);
            label1.Text = res.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var res = Regex.IsMatch(textBox1.Text, "^[a-z@]+[a-z.]+[a-z]+$", RegexOptions.IgnoreCase);
            label1.Text = res.ToString();   
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var res = Regex.Replace(textBox1.Text, "^[0-9]+$", "number");
            label1.Text = res.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var res = Regex.Split(textBox1.Text, "^[;-.|]$");
            foreach(var i in res)
            {
                label1.Text += i+"\n";
            }
        }
    }
}
