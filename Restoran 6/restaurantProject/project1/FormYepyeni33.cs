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
    public partial class FormYepyeni33 : Form
    {
        public FormYepyeni33()
        {
            InitializeComponent();
        }

        string imagepath;

        private void tableYepyeni33BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableYepyeni33BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.menuDataSet);

        }

        private void FormYepyeni33_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'menuDataSet.TableYepyeni33' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableYepyeni33TableAdapter.Fill(this.menuDataSet.TableYepyeni33);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resimPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }
        }
    }
}
