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
    public partial class FormLogin3 : Form
    {
        public FormLogin3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12345")
            {
                if (Application.OpenForms["FormMasalar"] == null)
                {
                    FormMasalar fm = new FormMasalar();
                    fm.Show();
                }
                else
                    Application.OpenForms["FormMasalar"].BringToFront();
            }
            else
            {
                string message = "Şifre Hatalı.";
                string title = "Başlık";
                MessageBox.Show(message, title);
            }
        }

        private void FormLogin3_Load(object sender, EventArgs e)
        {

        }
    }
}
