namespace project1
{
    partial class FormYepyeni2
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
            System.Windows.Forms.Label isimLabel;
            System.Windows.Forms.Label fiyatLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYepyeni2));
            this.button1 = new System.Windows.Forms.Button();
            this.tableYepyeni2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tableYepyeni2BindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tableYepyeni2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableYepyeni2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.resimPictureBox = new System.Windows.Forms.PictureBox();
            this.tableYepyeni2TableAdapter = new project1.menuDataSetTableAdapters.TableYepyeni2TableAdapter();
            this.tableAdapterManager = new project1.menuDataSetTableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            resimLabel = new System.Windows.Forms.Label();
            isimLabel = new System.Windows.Forms.Label();
            fiyatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni2BindingNavigator)).BeginInit();
            this.tableYepyeni2BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // resimLabel
            // 
            resimLabel.AutoSize = true;
            resimLabel.BackColor = System.Drawing.Color.Transparent;
            resimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            resimLabel.ForeColor = System.Drawing.Color.White;
            resimLabel.Location = new System.Drawing.Point(878, 354);
            resimLabel.Name = "resimLabel";
            resimLabel.Size = new System.Drawing.Size(78, 25);
            resimLabel.TabIndex = 9;
            resimLabel.Text = "Resim:";
            // 
            // isimLabel
            // 
            isimLabel.BackColor = System.Drawing.Color.Transparent;
            isimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            isimLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            isimLabel.Location = new System.Drawing.Point(70, 168);
            isimLabel.Name = "isimLabel";
            isimLabel.Size = new System.Drawing.Size(263, 22);
            isimLabel.TabIndex = 12;
            isimLabel.Text = "Girilecek Ürün İsmi:";
            // 
            // fiyatLabel
            // 
            fiyatLabel.BackColor = System.Drawing.Color.Transparent;
            fiyatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            fiyatLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            fiyatLabel.Location = new System.Drawing.Point(70, 212);
            fiyatLabel.Name = "fiyatLabel";
            fiyatLabel.Size = new System.Drawing.Size(263, 22);
            fiyatLabel.TabIndex = 13;
            fiyatLabel.Text = "Girilecek Ürün Fiyatı: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(989, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableYepyeni2BindingNavigator
            // 
            this.tableYepyeni2BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableYepyeni2BindingNavigator.BindingSource = this.tableYepyeni2BindingSource;
            this.tableYepyeni2BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableYepyeni2BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableYepyeni2BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tableYepyeni2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableYepyeni2BindingNavigatorSaveItem});
            this.tableYepyeni2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableYepyeni2BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableYepyeni2BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableYepyeni2BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableYepyeni2BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableYepyeni2BindingNavigator.Name = "tableYepyeni2BindingNavigator";
            this.tableYepyeni2BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableYepyeni2BindingNavigator.Size = new System.Drawing.Size(1312, 27);
            this.tableYepyeni2BindingNavigator.TabIndex = 1;
            this.tableYepyeni2BindingNavigator.Text = "bindingNavigator1";
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
            // tableYepyeni2BindingSource
            // 
            this.tableYepyeni2BindingSource.DataMember = "TableYepyeni2";
            this.tableYepyeni2BindingSource.DataSource = this.menuDataSet;
            // 
            // menuDataSet
            // 
            this.menuDataSet.DataSetName = "menuDataSet";
            this.menuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
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
            // tableYepyeni2BindingNavigatorSaveItem
            // 
            this.tableYepyeni2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableYepyeni2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableYepyeni2BindingNavigatorSaveItem.Image")));
            this.tableYepyeni2BindingNavigatorSaveItem.Name = "tableYepyeni2BindingNavigatorSaveItem";
            this.tableYepyeni2BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tableYepyeni2BindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.tableYepyeni2BindingNavigatorSaveItem.Click += new System.EventHandler(this.tableYepyeni2BindingNavigatorSaveItem_Click);
            // 
            // tableYepyeni2DataGridView
            // 
            this.tableYepyeni2DataGridView.AutoGenerateColumns = false;
            this.tableYepyeni2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableYepyeni2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableYepyeni2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tableYepyeni2DataGridView.DataSource = this.tableYepyeni2BindingSource;
            this.tableYepyeni2DataGridView.Location = new System.Drawing.Point(73, 354);
            this.tableYepyeni2DataGridView.Name = "tableYepyeni2DataGridView";
            this.tableYepyeni2DataGridView.RowHeadersWidth = 51;
            this.tableYepyeni2DataGridView.RowTemplate.Height = 24;
            this.tableYepyeni2DataGridView.Size = new System.Drawing.Size(680, 250);
            this.tableYepyeni2DataGridView.TabIndex = 2;
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
            this.isimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableYepyeni2BindingSource, "isim", true));
            this.isimTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimTextBox.Location = new System.Drawing.Point(383, 165);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(264, 30);
            this.isimTextBox.TabIndex = 6;
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableYepyeni2BindingSource, "fiyat", true));
            this.fiyatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatTextBox.Location = new System.Drawing.Point(383, 209);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(264, 30);
            this.fiyatTextBox.TabIndex = 8;
            // 
            // resimPictureBox
            // 
            this.resimPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableYepyeni2BindingSource, "resim", true));
            this.resimPictureBox.Location = new System.Drawing.Point(989, 354);
            this.resimPictureBox.Name = "resimPictureBox";
            this.resimPictureBox.Size = new System.Drawing.Size(250, 250);
            this.resimPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimPictureBox.TabIndex = 10;
            this.resimPictureBox.TabStop = false;
            // 
            // tableYepyeni2TableAdapter
            // 
            this.tableYepyeni2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.anaYemeklerTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.iceceklerTableAdapter = null;
            this.tableAdapterManager.salatalarTableAdapter = null;
            this.tableAdapterManager.TableEkleTableAdapter = null;
            this.tableAdapterManager.TableYepyeni1TableAdapter = null;
            this.tableAdapterManager.TableYepyeni2TableAdapter = this.tableYepyeni2TableAdapter;
            this.tableAdapterManager.TableYepyeni33TableAdapter = null;
            this.tableAdapterManager.TableYepyeni3TableAdapter = null;
            this.tableAdapterManager.tatlilarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project1.menuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.yanYemeklerrrTableAdapter = null;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(946, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tatlılar";
            // 
            // FormYepyeni2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project1.Properties.Resources.uzay_wp_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 653);
            this.Controls.Add(isimLabel);
            this.Controls.Add(fiyatLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isimTextBox);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(resimLabel);
            this.Controls.Add(this.resimPictureBox);
            this.Controls.Add(this.tableYepyeni2DataGridView);
            this.Controls.Add(this.tableYepyeni2BindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "FormYepyeni2";
            this.Text = "Tatlılar";
            this.Load += new System.EventHandler(this.FormYepyeni2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni2BindingNavigator)).EndInit();
            this.tableYepyeni2BindingNavigator.ResumeLayout(false);
            this.tableYepyeni2BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private menuDataSet menuDataSet;
        private System.Windows.Forms.BindingSource tableYepyeni2BindingSource;
        private menuDataSetTableAdapters.TableYepyeni2TableAdapter tableYepyeni2TableAdapter;
        private menuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableYepyeni2BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableYepyeni2BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tableYepyeni2DataGridView;
        private System.Windows.Forms.TextBox isimTextBox;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.PictureBox resimPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
    }
}