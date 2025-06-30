using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classLib;
using System.Data.Entity.Spatial;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BindingManagerBase bm = null;
        IEnumerable<Customer> custlist;
        Class1 ob = new Class1();


        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(CustomerType));


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
            bm.Position = bm.Count - 1;
            if (bm.Count == 0)
            {
                MessageBox.Show("No records to navigate to the last position.");
            }
            else
            {
                MessageBox.Show("Navigated to the last record successfully.");
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {   //Addcust

            Customer cust = new Customer();
            cust.CustomerId = int.Parse(textBox6.Text);
            cust.CustName = textBox1.Text;
            cust.Email = textBox2.Text;
            cust.Mobile = textBox3.Text;
            cust.Registeredon = DateTime.Now;
            cust.CustomerType = (CustomerType)(int)Enum.Parse(typeof(CustomerType), comboBox1.SelectedItem.ToString());

            var l1 = textBox4.Text;
            var l2 = textBox5.Text;
            cust.Location = System.Data.Entity.Spatial.DbGeography.FromText($"POINT({double.Parse(l1)} {double.Parse(l2)})", 4326);
            cust.Age= int.Parse(textBox7.Text);         

            ob.Add(cust);
            MessageBox.Show("Record added successfully.");

        }




        private void button6_Click(object sender, EventArgs e)
        {
            //deletecust
            int id;
            if (int.TryParse(textBox6.Text, out id))
            {
                int result = ob.delete(id);
                if (result > 0)
                {
                    MessageBox.Show("Record deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No record found with the given ID to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer ID.");
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            //searchbyid
            int id;

            if (int.TryParse(textBox6.Text, out id))
            {
                Customer cust = ob.searchbyid(id);
                if (cust != null)
                {
                    textBox6.Text = cust.CustomerId.ToString();
                    textBox1.Text = cust.CustName;
                    textBox2.Text = cust.Email;
                    textBox3.Text = cust.Mobile;
                    textBox4.Text = cust.Location.Longitude.ToString();
                    textBox5.Text = cust.Location.Latitude.ToString();
                    comboBox1.SelectedItem = (CustomerType)cust.CustomerType;
                    textBox7.Text = cust.Age.ToString();
                    MessageBox.Show("Record found successfully.");
                }
                else
                {
                    MessageBox.Show("No record found with the given ID.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer ID.");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            custlist = ob.display();
            bm = BindingContext[custlist];
            textBox6.DataBindings.Add("Text", custlist, "CustomerID");
            textBox1.DataBindings.Add("Text", custlist, "CustName");
            textBox2.DataBindings.Add("Text", custlist, "Email");
            textBox3.DataBindings.Add("Text", custlist, "Mobile");
            textBox4.DataBindings.Add("Text", custlist, "Location.Longitude");
            textBox5.DataBindings.Add("Text", custlist, "Location.Latitude");
            textBox7.DataBindings.Add("Text", custlist, "Age");
            comboBox1.DataBindings.Add("SelectedItem", custlist, "CustomerType");

        }
        private void button9_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string email = textBox2.Text.Trim();
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (string.IsNullOrWhiteSpace(email))
            {
                errorProvider1.SetError(textBox2, "Email is required.");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
            {
                errorProvider1.SetError(textBox2, "Enter a valid email address.");
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Customer name is required.");

            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[a-zA-Z\s]+$"))
            {
                errorProvider1.SetError(textBox1, "Customer name should contain only letters and spaces.");
            }
            else
            {
                //errorProvider1.SetError(textBox1, "");
                errorProvider1.Clear();
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox1, "Customer type is required.");
            }
            else
            {
                errorProvider1.SetError(comboBox1, "");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Longitude is required.");
            }

            else
            {
                errorProvider1.SetError(textBox4, "");
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            // Latitude
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                errorProvider1.SetError(textBox5, "Latitude is required.");
            }
            else
            {
                errorProvider1.SetError(textBox5, "");
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text.Trim(), @"^\d{10}$"))
            {
                errorProvider1.SetError(textBox3, "Mobile number is required.");
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox7.Text))
            {
                errorProvider1.SetError(textBox7, "Age is required and must be a positive integer.");
            }
            else
            {
                errorProvider1.SetError(textBox7, "");
            }
        }
    }
}
