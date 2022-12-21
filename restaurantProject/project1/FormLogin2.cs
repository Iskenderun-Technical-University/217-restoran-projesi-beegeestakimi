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
    public partial class FormLogin2 : Form
    {
        public FormLogin2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12345")
            {
                FormMenu fmenu = new FormMenu();
                fmenu.Show();
            }
            else
            {
                string message = "Şifre Hatalı.";
                string title = "Uyarı";
                MessageBox.Show(message, title);
            }
        }

        private void FormLogin2_Load(object sender, EventArgs e)
        {

        }
    }
}
