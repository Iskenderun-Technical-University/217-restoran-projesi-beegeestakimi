namespace project1
{
    partial class FormYepyeni1
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
            System.Windows.Forms.Label isimLabel;
            System.Windows.Forms.Label fiyatLabel;
            System.Windows.Forms.Label resimLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYepyeni1));
            this.tableYepyeni1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tableYepyeni1BindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tableYepyeni1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableYepyeni1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.resimPictureBox = new System.Windows.Forms.PictureBox();
            this.tableYepyeni1TableAdapter = new project1.menuDataSetTableAdapters.TableYepyeni1TableAdapter();
            this.tableAdapterManager = new project1.menuDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            isimLabel = new System.Windows.Forms.Label();
            fiyatLabel = new System.Windows.Forms.Label();
            resimLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni1BindingNavigator)).BeginInit();
            this.tableYepyeni1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // isimLabel
            // 
            isimLabel.AutoSize = true;
            isimLabel.Location = new System.Drawing.Point(92, 165);
            isimLabel.Name = "isimLabel";
            isimLabel.Size = new System.Drawing.Size(34, 16);
            isimLabel.TabIndex = 4;
            isimLabel.Text = "isim:";
            // 
            // fiyatLabel
            // 
            fiyatLabel.AutoSize = true;
            fiyatLabel.Location = new System.Drawing.Point(92, 193);
            fiyatLabel.Name = "fiyatLabel";
            fiyatLabel.Size = new System.Drawing.Size(34, 16);
            fiyatLabel.TabIndex = 6;
            fiyatLabel.Text = "fiyat:";
            // 
            // resimLabel
            // 
            resimLabel.AutoSize = true;
            resimLabel.Location = new System.Drawing.Point(789, 372);
            resimLabel.Name = "resimLabel";
            resimLabel.Size = new System.Drawing.Size(43, 16);
            resimLabel.TabIndex = 8;
            resimLabel.Text = "resim:";
            // 
            // tableYepyeni1BindingNavigator
            // 
            this.tableYepyeni1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableYepyeni1BindingNavigator.BindingSource = this.tableYepyeni1BindingSource;
            this.tableYepyeni1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableYepyeni1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableYepyeni1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tableYepyeni1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableYepyeni1BindingNavigatorSaveItem});
            this.tableYepyeni1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableYepyeni1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableYepyeni1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableYepyeni1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableYepyeni1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableYepyeni1BindingNavigator.Name = "tableYepyeni1BindingNavigator";
            this.tableYepyeni1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableYepyeni1BindingNavigator.Size = new System.Drawing.Size(1312, 27);
            this.tableYepyeni1BindingNavigator.TabIndex = 0;
            this.tableYepyeni1BindingNavigator.Text = "bindingNavigator1";
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
            // tableYepyeni1BindingSource
            // 
            this.tableYepyeni1BindingSource.DataMember = "TableYepyeni1";
            this.tableYepyeni1BindingSource.DataSource = this.menuDataSet;
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
            // tableYepyeni1BindingNavigatorSaveItem
            // 
            this.tableYepyeni1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableYepyeni1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableYepyeni1BindingNavigatorSaveItem.Image")));
            this.tableYepyeni1BindingNavigatorSaveItem.Name = "tableYepyeni1BindingNavigatorSaveItem";
            this.tableYepyeni1BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tableYepyeni1BindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.tableYepyeni1BindingNavigatorSaveItem.Click += new System.EventHandler(this.tableYepyeni1BindingNavigatorSaveItem_Click);
            // 
            // tableYepyeni1DataGridView
            // 
            this.tableYepyeni1DataGridView.AutoGenerateColumns = false;
            this.tableYepyeni1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableYepyeni1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableYepyeni1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tableYepyeni1DataGridView.DataSource = this.tableYepyeni1BindingSource;
            this.tableYepyeni1DataGridView.Location = new System.Drawing.Point(82, 372);
            this.tableYepyeni1DataGridView.Name = "tableYepyeni1DataGridView";
            this.tableYepyeni1DataGridView.RowHeadersWidth = 51;
            this.tableYepyeni1DataGridView.RowTemplate.Height = 24;
            this.tableYepyeni1DataGridView.Size = new System.Drawing.Size(663, 220);
            this.tableYepyeni1DataGridView.TabIndex = 1;
            this.tableYepyeni1DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableYepyeni1DataGridView_CellContentClick);
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
            this.isimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableYepyeni1BindingSource, "isim", true));
            this.isimTextBox.Location = new System.Drawing.Point(141, 162);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(343, 22);
            this.isimTextBox.TabIndex = 5;
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableYepyeni1BindingSource, "fiyat", true));
            this.fiyatTextBox.Location = new System.Drawing.Point(141, 190);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(343, 22);
            this.fiyatTextBox.TabIndex = 7;
            // 
            // resimPictureBox
            // 
            this.resimPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableYepyeni1BindingSource, "resim", true));
            this.resimPictureBox.Location = new System.Drawing.Point(838, 372);
            this.resimPictureBox.Name = "resimPictureBox";
            this.resimPictureBox.Size = new System.Drawing.Size(247, 201);
            this.resimPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimPictureBox.TabIndex = 9;
            this.resimPictureBox.TabStop = false;
            this.resimPictureBox.Click += new System.EventHandler(this.resimPictureBox_Click);
            // 
            // tableYepyeni1TableAdapter
            // 
            this.tableYepyeni1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.anaYemeklerTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.iceceklerTableAdapter = null;
            this.tableAdapterManager.salatalarTableAdapter = null;
            this.tableAdapterManager.TableEkleTableAdapter = null;
            this.tableAdapterManager.TableYepyeni1TableAdapter = this.tableYepyeni1TableAdapter;
            this.tableAdapterManager.TableYepyeni2TableAdapter = null;
            this.tableAdapterManager.TableYepyeni33TableAdapter = null;
            this.tableAdapterManager.TableYepyeni3TableAdapter = null;
            this.tableAdapterManager.tatlilarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project1.menuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.yanYemeklerrrTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(916, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(647, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "Yan Yemekler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormYepyeni1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(isimLabel);
            this.Controls.Add(this.isimTextBox);
            this.Controls.Add(fiyatLabel);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(resimLabel);
            this.Controls.Add(this.resimPictureBox);
            this.Controls.Add(this.tableYepyeni1DataGridView);
            this.Controls.Add(this.tableYepyeni1BindingNavigator);
            this.Name = "FormYepyeni1";
            this.Text = "Yan Yemekler";
            this.Load += new System.EventHandler(this.FormYepyeni1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni1BindingNavigator)).EndInit();
            this.tableYepyeni1BindingNavigator.ResumeLayout(false);
            this.tableYepyeni1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private menuDataSet menuDataSet;
        private System.Windows.Forms.BindingSource tableYepyeni1BindingSource;
        private menuDataSetTableAdapters.TableYepyeni1TableAdapter tableYepyeni1TableAdapter;
        private menuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableYepyeni1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableYepyeni1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tableYepyeni1DataGridView;
        private System.Windows.Forms.TextBox isimTextBox;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.PictureBox resimPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}