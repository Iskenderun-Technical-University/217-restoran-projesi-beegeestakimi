using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        private void Form1_Load(object sender, EventArgs e)
        { 
            
        }










        private void button1_Click(object sender, EventArgs e)
        {
               }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            SqlDataReader oku;
            baglanti.Open();

            komut.Connection = baglanti;
            komut.CommandText = "select *from Table";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["Price"].ToString());
            }
            baglanti.Close();
        }
    }
}
