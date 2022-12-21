namespace project1
{
    partial class FormEkle
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label resimLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEkle));
            System.Windows.Forms.Label isimLabel;
            System.Windows.Forms.Label fiyatLabel;
            this.tableEkleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tableEkleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuDataSet = new project1.menuDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableEkleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableEkleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.resimPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableEkleTableAdapter = new project1.menuDataSetTableAdapters.TableEkleTableAdapter();
            this.tableAdapterManager = new project1.menuDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            resimLabel = new System.Windows.Forms.Label();
            isimLabel = new System.Windows.Forms.Label();
            fiyatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableEkleBindingNavigator)).BeginInit();
            this.tableEkleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableEkleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEkleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // resimLabel
            // 
            resimLabel.AutoSize = true;
            resimLabel.Location = new System.Drawing.Point(866, 373);
            resimLabel.Name = "resimLabel";
            resimLabel.Size = new System.Drawing.Size(43, 16);
            resimLabel.TabIndex = 6;
            resimLabel.Text = "resim:";
            // 
            // tableEkleBindingNavigator
            // 
            this.tableEkleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableEkleBindingNavigator.BindingSource = this.tableEkleBindingSource;
            this.tableEkleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableEkleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableEkleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tableEkleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableEkleBindingNavigatorSaveItem});
            this.tableEkleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableEkleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableEkleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableEkleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableEkleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableEkleBindingNavigator.Name = "tableEkleBindingNavigator";
            this.tableEkleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableEkleBindingNavigator.Size = new System.Drawing.Size(1312, 27);
            this.tableEkleBindingNavigator.TabIndex = 0;
            this.tableEkleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Yeni ekle";
            // 
            // tableEkleBindingSource
            // 
            this.tableEkleBindingSource.DataMember = "TableEkle";
            this.tableEkleBindingSource.DataSource = this.menuDataSet;
            // 
            // menuDataSet
            // 
            this.menuDataSet.DataSetName = "menuDataSet";
            this.menuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tableEkleBindingNavigatorSaveItem
            // 
            this.tableEkleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableEkleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableEkleBindingNavigatorSaveItem.Image")));
            this.tableEkleBindingNavigatorSaveItem.Name = "tableEkleBindingNavigatorSaveItem";
            this.tableEkleBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tableEkleBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.tableEkleBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableEkleBindingNavigatorSaveItem_Click);
            // 
            // tableEkleDataGridView
            // 
            this.tableEkleDataGridView.AutoGenerateColumns = false;
            this.tableEkleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableEkleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableEkleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tableEkleDataGridView.DataSource = this.tableEkleBindingSource;
            this.tableEkleDataGridView.Location = new System.Drawing.Point(57, 373);
            this.tableEkleDataGridView.Name = "tableEkleDataGridView";
            this.tableEkleDataGridView.RowHeadersWidth = 51;
            this.tableEkleDataGridView.RowTemplate.Height = 24;
            this.tableEkleDataGridView.Size = new System.Drawing.Size(734, 226);
            this.tableEkleDataGridView.TabIndex = 1;
            this.tableEkleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableEkleDataGridView_CellClick);
            this.tableEkleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableEkleDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "isim";
            this.dataGridViewTextBoxColumn2.HeaderText = "isim";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fiyat";
            this.dataGridViewTextBoxColumn3.HeaderText = "fiyat";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // isimTextBox
            // 
            this.isimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableEkleBindingSource, "isim", true));
            this.isimTextBox.Location = new System.Drawing.Point(169, 160);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(244, 22);
            this.isimTextBox.TabIndex = 3;
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableEkleBindingSource, "fiyat", true));
            this.fiyatTextBox.Location = new System.Drawing.Point(169, 184);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(244, 22);
            this.fiyatTextBox.TabIndex = 5;
            // 
            // resimPictureBox
            // 
            this.resimPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableEkleBindingSource, "resim", true));
            this.resimPictureBox.Location = new System.Drawing.Point(938, 373);
            this.resimPictureBox.Name = "resimPictureBox";
            this.resimPictureBox.Size = new System.Drawing.Size(235, 211);
            this.resimPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimPictureBox.TabIndex = 7;
            this.resimPictureBox.TabStop = false;
            this.resimPictureBox.Click += new System.EventHandler(this.resimPictureBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1007, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableEkleTableAdapter
            // 
            this.tableEkleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.anaYemeklerTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.iceceklerTableAdapter = null;
            this.tableAdapterManager.salatalarTableAdapter = null;
            this.tableAdapterManager.TableEkleTableAdapter = this.tableEkleTableAdapter;
            this.tableAdapterManager.TableYepyeni1TableAdapter = null;
            this.tableAdapterManager.TableYepyeni2TableAdapter = null;
            this.tableAdapterManager.TableYepyeni33TableAdapter = null;
            this.tableAdapterManager.TableYepyeni3TableAdapter = null;
            this.tableAdapterManager.tatlilarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project1.menuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.yanYemeklerrrTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(669, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ana Yemekler";
            // 
            // isimLabel
            // 
            isimLabel.BackColor = System.Drawing.Color.Transparent;
            isimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isimLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            isimLabel.Location = new System.Drawing.Point(12, 159);
            isimLabel.Name = "isimLabel";
            isimLabel.Size = new System.Drawing.Size(160, 22);
            isimLabel.TabIndex = 14;
            isimLabel.Text = "Girilecek Ürün İsmi:";
            // 
            // fiyatLabel
            // 
            fiyatLabel.BackColor = System.Drawing.Color.Transparent;
            fiyatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fiyatLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            fiyatLabel.Location = new System.Drawing.Point(12, 187);
            fiyatLabel.Name = "fiyatLabel";
            fiyatLabel.Size = new System.Drawing.Size(160, 22);
            fiyatLabel.TabIndex = 15;
            fiyatLabel.Text = "Girilecek Ürün Fiyatı: ";
            // 
            // FormEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project1.Properties.Resources.uzay_wp_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 653);
            this.Controls.Add(isimLabel);
            this.Controls.Add(fiyatLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(resimLabel);
            this.Controls.Add(this.resimPictureBox);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(this.isimTextBox);
            this.Controls.Add(this.tableEkleDataGridView);
            this.Controls.Add(this.tableEkleBindingNavigator);
            this.Name = "FormEkle";
            this.Text = "Ana Yemekler";
            this.Load += new System.EventHandler(this.FormEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableEkleBindingNavigator)).EndInit();
            this.tableEkleBindingNavigator.ResumeLayout(false);
            this.tableEkleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableEkleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEkleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private menuDataSet menuDataSet;
        private System.Windows.Forms.BindingSource tableEkleBindingSource;
        private menuDataSetTableAdapters.TableEkleTableAdapter tableEkleTableAdapter;
        private menuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableEkleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableEkleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tableEkleDataGridView;
        private System.Windows.Forms.TextBox isimTextBox;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.PictureBox resimPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
    }
}