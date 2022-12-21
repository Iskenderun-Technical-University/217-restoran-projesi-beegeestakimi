using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class FormEkle : Form
    {
        public FormEkle()
        {
            InitializeComponent();
        }

        string imagepath;

        private void tableEkleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableEkleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.menuDataSet);
        }

        private void FormEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'menuDataSet.TableEkle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableEkleTableAdapter.Fill(this.menuDataSet.TableEkle);

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableEkleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tableEkleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resimPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void isimLabel_Click(object sender, EventArgs e)
        {

        }

        private void fiyatLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
