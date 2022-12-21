namespace project1
{
    partial class FormYepyeni33
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYepyeni33));
            this.menuDataSet = new project1.menuDataSet();
            this.tableYepyeni33BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableYepyeni33TableAdapter = new project1.menuDataSetTableAdapters.TableYepyeni33TableAdapter();
            this.tableAdapterManager = new project1.menuDataSetTableAdapters.TableAdapterManager();
            this.tableYepyeni33BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.tableYepyeni33BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableYepyeni33DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.resimPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            resimLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni33BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni33BindingNavigator)).BeginInit();
            this.tableYepyeni33BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni33DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // resimLabel
            // 
            resimLabel.AutoSize = true;
            resimLabel.BackColor = System.Drawing.Color.Transparent;
            resimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            resimLabel.ForeColor = System.Drawing.Color.White;
            resimLabel.Location = new System.Drawing.Point(892, 358);
            resimLabel.Name = "resimLabel";
            resimLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            resimLabel.Size = new System.Drawing.Size(78, 25);
            resimLabel.TabIndex = 8;
            resimLabel.Text = "Resim:";
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(69, 196);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(277, 22);
            label2.TabIndex = 14;
            label2.Text = "Girilecek Ürün İsmi:";
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(69, 242);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(277, 22);
            label3.TabIndex = 15;
            label3.Text = "Girilecek Ürün Fiyatı: ";
            // 
            // menuDataSet
            // 
            this.menuDataSet.DataSetName = "menuDataSet";
            this.menuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableYepyeni33BindingSource
            // 
            this.tableYepyeni33BindingSource.DataMember = "TableYepyeni33";
            this.tableYepyeni33BindingSource.DataSource = this.menuDataSet;
            // 
            // tableYepyeni33TableAdapter
            // 
            this.tableYepyeni33TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.anaYemeklerTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.iceceklerTableAdapter = null;
            this.tableAdapterManager.salatalarTableAdapter = null;
            this.tableAdapterManager.TableEkleTableAdapter = null;
            this.tableAdapterManager.TableYepyeni1TableAdapter = null;
            this.tableAdapterManager.TableYepyeni2TableAdapter = null;
            this.tableAdapterManager.TableYepyeni33TableAdapter = this.tableYepyeni33TableAdapter;
            this.tableAdapterManager.TableYepyeni3TableAdapter = null;
            this.tableAdapterManager.tatlilarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project1.menuDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.yanYemeklerrrTableAdapter = null;
            // 
            // tableYepyeni33BindingNavigator
            // 
            this.tableYepyeni33BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableYepyeni33BindingNavigator.BindingSource = this.tableYepyeni33BindingSource;
            this.tableYepyeni33BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableYepyeni33BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableYepyeni33BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tableYepyeni33BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableYepyeni33BindingNavigatorSaveItem});
            this.tableYepyeni33BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableYepyeni33BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableYepyeni33BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableYepyeni33BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableYepyeni33BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableYepyeni33BindingNavigator.Name = "tableYepyeni33BindingNavigator";
            this.tableYepyeni33BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableYepyeni33BindingNavigator.Size = new System.Drawing.Size(1312, 27);
            this.tableYepyeni33BindingNavigator.TabIndex = 0;
            this.tableYepyeni33BindingNavigator.Text = "bindingNavigator1";
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
            // tableYepyeni33BindingNavigatorSaveItem
            // 
            this.tableYepyeni33BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableYepyeni33BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableYepyeni33BindingNavigatorSaveItem.Image")));
            this.tableYepyeni33BindingNavigatorSaveItem.Name = "tableYepyeni33BindingNavigatorSaveItem";
            this.tableYepyeni33BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tableYepyeni33BindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.tableYepyeni33BindingNavigatorSaveItem.Click += new System.EventHandler(this.tableYepyeni33BindingNavigatorSaveItem_Click);
            // 
            // tableYepyeni33DataGridView
            // 
            this.tableYepyeni33DataGridView.AutoGenerateColumns = false;
            this.tableYepyeni33DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableYepyeni33DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableYepyeni33DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tableYepyeni33DataGridView.DataSource = this.tableYepyeni33BindingSource;
            this.tableYepyeni33DataGridView.Location = new System.Drawing.Point(74, 358);
            this.tableYepyeni33DataGridView.Name = "tableYepyeni33DataGridView";
            this.tableYepyeni33DataGridView.RowHeadersWidth = 51;
            this.tableYepyeni33DataGridView.RowTemplate.Height = 24;
            this.tableYepyeni33DataGridView.Size = new System.Drawing.Size(711, 250);
            this.tableYepyeni33DataGridView.TabIndex = 1;
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
            this.isimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableYepyeni33BindingSource, "isim", true));
            this.isimTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimTextBox.Location = new System.Drawing.Point(401, 196);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(274, 30);
            this.isimTextBox.TabIndex = 5;
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableYepyeni33BindingSource, "fiyat", true));
            this.fiyatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatTextBox.Location = new System.Drawing.Point(401, 242);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(274, 30);
            this.fiyatTextBox.TabIndex = 7;
            // 
            // resimPictureBox
            // 
            this.resimPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableYepyeni33BindingSource, "resim", true));
            this.resimPictureBox.Location = new System.Drawing.Point(1004, 358);
            this.resimPictureBox.Name = "resimPictureBox";
            this.resimPictureBox.Size = new System.Drawing.Size(250, 250);
            this.resimPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimPictureBox.TabIndex = 9;
            this.resimPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1004, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 51);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(872, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "İçecekler";
            // 
            // FormYepyeni33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::project1.Properties.Resources.uzay_wp_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 653);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isimTextBox);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(resimLabel);
            this.Controls.Add(this.resimPictureBox);
            this.Controls.Add(this.tableYepyeni33DataGridView);
            this.Controls.Add(this.tableYepyeni33BindingNavigator);
            this.Name = "FormYepyeni33";
            this.Text = "İçecekler";
            this.Load += new System.EventHandler(this.FormYepyeni33_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni33BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni33BindingNavigator)).EndInit();
            this.tableYepyeni33BindingNavigator.ResumeLayout(false);
            this.tableYepyeni33BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableYepyeni33DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private menuDataSet menuDataSet;
        private System.Windows.Forms.BindingSource tableYepyeni33BindingSource;
        private menuDataSetTableAdapters.TableYepyeni33TableAdapter tableYepyeni33TableAdapter;
        private menuDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableYepyeni33BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableYepyeni33BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tableYepyeni33DataGridView;
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