
namespace WindowsFormsProject
{
    partial class SupplyList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplyList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowInsertTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowUpdateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traidingCompanyDataSet = new WindowsFormsProject.TraidingCompanyDataSet();
            this.supplyTableAdapter = new WindowsFormsProject.TraidingCompanyDataSetTableAdapters.SupplyTableAdapter();
            this.AddSupply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DeleteSuppBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxCategorySearch = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traidingCompanyDataSet7 = new WindowsFormsProject.TraidingCompanyDataSet7();
            this.categoryTableAdapter = new WindowsFormsProject.TraidingCompanyDataSet7TableAdapters.CategoryTableAdapter();
            this.buttonCencelSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSupplyDataGridViewTextBoxColumn,
            this.iDPersonDataGridViewTextBoxColumn,
            this.iDCategoryDataGridViewTextBoxColumn,
            this.nameGoodsDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.priceUnitDataGridViewTextBoxColumn,
            this.rowInsertTimeDataGridViewTextBoxColumn,
            this.rowUpdateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDSupplyDataGridViewTextBoxColumn
            // 
            this.iDSupplyDataGridViewTextBoxColumn.DataPropertyName = "ID_Supply";
            this.iDSupplyDataGridViewTextBoxColumn.HeaderText = "ID_Supply";
            this.iDSupplyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDSupplyDataGridViewTextBoxColumn.Name = "iDSupplyDataGridViewTextBoxColumn";
            this.iDSupplyDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSupplyDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPersonDataGridViewTextBoxColumn
            // 
            this.iDPersonDataGridViewTextBoxColumn.DataPropertyName = "ID_Person";
            this.iDPersonDataGridViewTextBoxColumn.HeaderText = "ID_Person";
            this.iDPersonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPersonDataGridViewTextBoxColumn.Name = "iDPersonDataGridViewTextBoxColumn";
            this.iDPersonDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCategoryDataGridViewTextBoxColumn
            // 
            this.iDCategoryDataGridViewTextBoxColumn.DataPropertyName = "ID_Category";
            this.iDCategoryDataGridViewTextBoxColumn.HeaderText = "ID_Category";
            this.iDCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCategoryDataGridViewTextBoxColumn.Name = "iDCategoryDataGridViewTextBoxColumn";
            this.iDCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameGoodsDataGridViewTextBoxColumn
            // 
            this.nameGoodsDataGridViewTextBoxColumn.DataPropertyName = "NameGoods";
            this.nameGoodsDataGridViewTextBoxColumn.HeaderText = "NameGoods";
            this.nameGoodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameGoodsDataGridViewTextBoxColumn.Name = "nameGoodsDataGridViewTextBoxColumn";
            this.nameGoodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceUnitDataGridViewTextBoxColumn
            // 
            this.priceUnitDataGridViewTextBoxColumn.DataPropertyName = "PriceUnit";
            this.priceUnitDataGridViewTextBoxColumn.HeaderText = "PriceUnit";
            this.priceUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceUnitDataGridViewTextBoxColumn.Name = "priceUnitDataGridViewTextBoxColumn";
            this.priceUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // rowInsertTimeDataGridViewTextBoxColumn
            // 
            this.rowInsertTimeDataGridViewTextBoxColumn.DataPropertyName = "RowInsertTime";
            this.rowInsertTimeDataGridViewTextBoxColumn.HeaderText = "RowInsertTime";
            this.rowInsertTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rowInsertTimeDataGridViewTextBoxColumn.Name = "rowInsertTimeDataGridViewTextBoxColumn";
            this.rowInsertTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // rowUpdateTimeDataGridViewTextBoxColumn
            // 
            this.rowUpdateTimeDataGridViewTextBoxColumn.DataPropertyName = "RowUpdateTime";
            this.rowUpdateTimeDataGridViewTextBoxColumn.HeaderText = "RowUpdateTime";
            this.rowUpdateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rowUpdateTimeDataGridViewTextBoxColumn.Name = "rowUpdateTimeDataGridViewTextBoxColumn";
            this.rowUpdateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataMember = "Supply";
            this.supplyBindingSource.DataSource = this.traidingCompanyDataSet;
            // 
            // traidingCompanyDataSet
            // 
            this.traidingCompanyDataSet.DataSetName = "TraidingCompanyDataSet";
            this.traidingCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplyTableAdapter
            // 
            this.supplyTableAdapter.ClearBeforeFill = true;
            // 
            // AddSupply
            // 
            this.AddSupply.Location = new System.Drawing.Point(563, 317);
            this.AddSupply.Name = "AddSupply";
            this.AddSupply.Size = new System.Drawing.Size(136, 43);
            this.AddSupply.TabIndex = 1;
            this.AddSupply.Text = "Add Supply";
            this.AddSupply.UseVisualStyleBackColor = true;
            this.AddSupply.Click += new System.EventHandler(this.AddSupply_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sort by price";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeleteSuppBt
            // 
            this.DeleteSuppBt.Location = new System.Drawing.Point(731, 316);
            this.DeleteSuppBt.Name = "DeleteSuppBt";
            this.DeleteSuppBt.Size = new System.Drawing.Size(131, 42);
            this.DeleteSuppBt.TabIndex = 5;
            this.DeleteSuppBt.Text = "Delete";
            this.DeleteSuppBt.UseVisualStyleBackColor = true;
            this.DeleteSuppBt.Click += new System.EventHandler(this.DeleteSuppBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxCategorySearch
            // 
            this.comboBoxCategorySearch.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "CategoryName", true));
            this.comboBoxCategorySearch.DataSource = this.categoryBindingSource;
            this.comboBoxCategorySearch.DisplayMember = "CategoryName";
            this.comboBoxCategorySearch.FormattingEnabled = true;
            this.comboBoxCategorySearch.Location = new System.Drawing.Point(34, 12);
            this.comboBoxCategorySearch.Name = "comboBoxCategorySearch";
            this.comboBoxCategorySearch.Size = new System.Drawing.Size(131, 24);
            this.comboBoxCategorySearch.TabIndex = 8;
            this.comboBoxCategorySearch.ValueMember = "ID_Category";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.traidingCompanyDataSet7;
            // 
            // traidingCompanyDataSet7
            // 
            this.traidingCompanyDataSet7.DataSetName = "TraidingCompanyDataSet7";
            this.traidingCompanyDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // buttonCencelSearch
            // 
            this.buttonCencelSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCencelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCencelSearch.Location = new System.Drawing.Point(34, 113);
            this.buttonCencelSearch.Name = "buttonCencelSearch";
            this.buttonCencelSearch.Size = new System.Drawing.Size(131, 25);
            this.buttonCencelSearch.TabIndex = 5;
            this.buttonCencelSearch.Text = "Cancel res Search";
            this.buttonCencelSearch.UseVisualStyleBackColor = true;
            this.buttonCencelSearch.Click += new System.EventHandler(this.buttonCencelSearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(795, 413);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.comboBoxCategorySearch);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonCencelSearch);
            this.panel1.Location = new System.Drawing.Point(196, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 145);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(196, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select a category to search:\r\n";
            this.label1.UseCompatibleTextRendering = true;
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SupplyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(889, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteSuppBt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddSupply);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplyList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplyList";
            this.Load += new System.EventHandler(this.SupplyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private TraidingCompanyDataSet traidingCompanyDataSet;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private TraidingCompanyDataSetTableAdapters.SupplyTableAdapter supplyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSupplyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowInsertTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowUpdateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddSupply;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DeleteSuppBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxCategorySearch;
        private TraidingCompanyDataSet7 traidingCompanyDataSet7;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private TraidingCompanyDataSet7TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button buttonCencelSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}