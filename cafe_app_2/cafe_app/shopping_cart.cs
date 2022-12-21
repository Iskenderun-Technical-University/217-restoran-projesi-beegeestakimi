using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_app
{
    public partial class shopping_cart : UserControl
    {
        public shopping_cart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_add_prod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
                return;
            ListViewItem item = new ListViewItem(comboBox1.Text);
            shop_list.Items.Add(item);
        }

        private void button_remove_prod_Click(object sender, EventArgs e)
        {
            if (shop_list.Items.Count > 0)
                shop_list.Items.Remove(shop_list.SelectedItems[0]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
