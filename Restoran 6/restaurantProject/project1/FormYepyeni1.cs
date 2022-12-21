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
    public partial class FormYepyeni1 : Form
    {
        public FormYepyeni1()
        {
            InitializeComponent();
        }

        string imagepath;

        private void tableYepyeni1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableYepyeni1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.menuDataSet);

        }

        private void FormYepyeni1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'menuDataSet.TableYepyeni1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableYepyeni1TableAdapter.Fill(this.menuDataSet.TableYepyeni1);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resimPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void tableYepyeni1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
