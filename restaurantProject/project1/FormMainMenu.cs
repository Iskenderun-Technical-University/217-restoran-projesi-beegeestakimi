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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMasalar fm = new FormMasalar();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenu fmenu = new FormMenu();
            fmenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMenuMusteri fmm = new FormMenuMusteri();
            fmm.Show();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
