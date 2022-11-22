namespace cafe_app
{
    partial class shopping_cart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shop_list = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add_prod = new System.Windows.Forms.Button();
            this.button_remove_prod = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // shop_list
            // 
            this.shop_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.price});
            this.shop_list.Location = new System.Drawing.Point(470, 123);
            this.shop_list.Name = "shop_list";
            this.shop_list.Size = new System.Drawing.Size(321, 339);
            this.shop_list.TabIndex = 0;
            this.shop_list.UseCompatibleStateImageBehavior = false;
            this.shop_list.View = System.Windows.Forms.View.Details;
            this.shop_list.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "İsim";
            this.name.Width = 250;
            // 
            // price
            // 
            this.price.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zilla Slab", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(470, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Masa Siparişleri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zilla Slab", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Girişi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zilla Slab", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adı:";
            // 
            // button_add_prod
            // 
            this.button_add_prod.Location = new System.Drawing.Point(121, 189);
            this.button_add_prod.Name = "button_add_prod";
            this.button_add_prod.Size = new System.Drawing.Size(56, 28);
            this.button_add_prod.TabIndex = 7;
            this.button_add_prod.Text = "Ekle";
            this.button_add_prod.UseVisualStyleBackColor = true;
            this.button_add_prod.Click += new System.EventHandler(this.button_add_prod_Click);
            // 
            // button_remove_prod
            // 
            this.button_remove_prod.Location = new System.Drawing.Point(216, 189);
            this.button_remove_prod.Name = "button_remove_prod";
            this.button_remove_prod.Size = new System.Drawing.Size(56, 28);
            this.button_remove_prod.TabIndex = 8;
            this.button_remove_prod.Text = "Sil";
            this.button_remove_prod.UseVisualStyleBackColor = true;
            this.button_remove_prod.Click += new System.EventHandler(this.button_remove_prod_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Patates",
            "Köfte",
            "Balık"});
            this.comboBox1.Location = new System.Drawing.Point(121, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // shopping_cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_remove_prod);
            this.Controls.Add(this.button_add_prod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shop_list);
            this.Name = "shopping_cart";
            this.Size = new System.Drawing.Size(819, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView shop_list;
        private Label label1;
        private ColumnHeader name;
        private ColumnHeader price;
        private Label label2;
        private Label label3;
        private Button button_add_prod;
        private Button button_remove_prod;
        private ComboBox comboBox1;
    }
}
