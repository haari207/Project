using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Mywinapp
{
    public partial class MyNotepad : Form
    {
        public MyNotepad()
        {
            InitializeComponent();
        }

     
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c=new ColorDialog();
            c.ShowDialog();
            richTextBox1.ForeColor = c.Color;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ob=new SaveFileDialog();
            ob.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (ob.ShowDialog() == DialogResult.OK)
            {
                string filePath = ob.FileName;
               File.WriteAllText(filePath, ob.FileName);
            }
            ob.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog ob=new PrintDialog();
            ob.ShowDialog();
        }

       

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorToolStripMenuItem_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ob = new OpenFileDialog();
            ob.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (ob.ShowDialog() == DialogResult.OK)
            {
                string filePath = ob.FileName;
                string content = File.ReadAllText(filePath);
                richTextBox1.Text = content;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            colorToolStripMenuItem_Click(sender, e);

        }

        private void MyNotepad_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            toolStripStatusLabel2.Text = "jai@gmail.com";
        }
    }
}
