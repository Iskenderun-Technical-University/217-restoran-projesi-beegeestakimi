using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class FormMenuMusteri : Form
    {
        public FormMenuMusteri()
        {
            InitializeComponent();
        }

        private void FormMenuMusteri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'menuDataSet.TableYepyeni33' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableYepyeni33TableAdapter.Fill(this.menuDataSet.TableYepyeni33);
            // TODO: Bu kod satırı 'menuDataSet.TableYepyeni2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableYepyeni2TableAdapter.Fill(this.menuDataSet.TableYepyeni2);
            // TODO: Bu kod satırı 'menuDataSet.TableYepyeni1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableYepyeni1TableAdapter.Fill(this.menuDataSet.TableYepyeni1);
            // TODO: Bu kod satırı 'menuDataSet.TableEkle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableEkleTableAdapter.Fill(this.menuDataSet.TableEkle);
            // TODO: Bu kod satırı 'menuDataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tableTableAdapter.Fill(this.menuDataSet.Table);
            // TODO: Bu kod satırı 'menuDataSet.icecekler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.iceceklerTableAdapter.Fill(this.menuDataSet.icecekler);
            // TODO: Bu kod satırı 'menuDataSet.tatlilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tatlilarTableAdapter.Fill(this.menuDataSet.tatlilar);
            // TODO: Bu kod satırı 'menuDataSet.anaYemekler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.anaYemeklerTableAdapter.Fill(this.menuDataSet.anaYemekler);
            // TODO: Bu kod satırı 'menuDataSet.yanYemeklerrr' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.yanYemeklerrrTableAdapter.Fill(this.menuDataSet.yanYemeklerrr);

            /*
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\thwisse\\OneDrive\\C# Programming\\restaurantProject\\project1\\menu.mdf\"; Integrated Security = True;");
            con.Open();

            SqlDataAdapter adap = new SqlDataAdapter("Select * from anaYemekler.isim", con);

            DataTable dt = new DataTable();

            adap.Fill(dt);

            con.Close();
            */
        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_Click(object sender, EventArgs e)
        {
            //resimPictureBox.Image = 
        }
    }
}
