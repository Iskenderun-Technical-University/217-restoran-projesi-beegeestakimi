using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class FormMasalar : Form
    {
        public FormMasalar()
        {
            InitializeComponent();
            
        }

        private void FormMasalar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {   if (listBox1.Text == "")
            {
                string textmasa1 = richTextBox9.Text;
                listBox1.Items.Add(textmasa1);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string textmasa2 = richTextBox9.Text;
            listBox2.Items.Add(textmasa2);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string textmasa3 = richTextBox9.Text;
            listBox3.Items.Add(textmasa3);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string textmasa4 = richTextBox9.Text;
            listBox4.Items.Add(textmasa4);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string textmasa5 = richTextBox9.Text;
            listBox5.Items.Add(textmasa5);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string textmasa6 = richTextBox9.Text;
            listBox6.Items.Add(textmasa6);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string textmasa7 = richTextBox9.Text;
            listBox7.Items.Add(textmasa7);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string textmasa8 = richTextBox9.Text;
            listBox8.Items.Add(textmasa8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
