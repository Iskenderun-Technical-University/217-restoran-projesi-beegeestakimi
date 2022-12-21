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
           FormLogin3 lg3 = new FormLogin3();
            lg3.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin2 lg2 = new FormLogin2();
            lg2.Show();
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
