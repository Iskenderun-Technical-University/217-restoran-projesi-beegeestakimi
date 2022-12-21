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
    public partial class FormYepyeni2 : Form
    {
        public FormYepyeni2()
        {
            InitializeComponent();
        }

        string imagepath;

        private void tableYepyeni2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableYepyeni2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.menuDataSet);

        }

        private void FormYepyeni2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'menuDataSet.TableYepyeni2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableYepyeni2TableAdapter.Fill(this.menuDataSet.TableYepyeni2);

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
