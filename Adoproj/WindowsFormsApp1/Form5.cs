﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

      

        private void Form5_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("C:\\dotnetdemo\\details.xml");
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
