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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormYepyeni33 f33 = new FormYepyeni33();
            f33.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormYepyeni2 f2 = new FormYepyeni2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEkle fe = new FormEkle();
            fe.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormYepyeni1 f1 = new FormYepyeni1();
            f1.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
