
namespace WindowsFormsProject
{
    partial class AddSupply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupply));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNameGoods = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxPriceUnit = new System.Windows.Forms.TextBox();
            this.AddSupp = new System.Windows.Forms.Button();
            this.traidingCompanyDataSet1 = new WindowsFormsProject.TraidingCompanyDataSet1();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new WindowsFormsProject.TraidingCompanyDataSet1TableAdapters.CategoryTableAdapter();
            this.comboBoxIdCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.traidingCompanyDataSet6 = new WindowsFormsProject.TraidingCompanyDataSet6();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxIdPerson = new System.Windows.Forms.ComboBox();
            this.personBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.traidingCompanyDataSet5 = new WindowsFormsProject.TraidingCompanyDataSet5();
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.traidingCompanyDataSet3 = new WindowsFormsProject.TraidingCompanyDataSet3();
            this.traidingCompanyDataSet2 = new WindowsFormsProject.TraidingCompanyDataSet2();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter = new WindowsFormsProject.TraidingCompanyDataSet2TableAdapters.PersonTableAdapter();
            this.personTableAdapter1 = new WindowsFormsProject.TraidingCompanyDataSet3TableAdapters.PersonTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter2 = new WindowsFormsProject.TraidingCompanyDataSet5TableAdapters.PersonTableAdapter();
            this.categoryTableAdapter1 = new WindowsFormsProject.TraidingCompanyDataSet6TableAdapters.CategoryTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBoxNameGoods
            // 
            resources.ApplyResources(this.textBoxNameGoods, "textBoxNameGoods");
            this.textBoxNameGoods.Name = "textBoxNameGoods";
            // 
            // textBoxNumber
            // 
            resources.ApplyResources(this.textBoxNumber, "textBoxNumber");
            this.textBoxNumber.Name = "textBoxNumber";
            // 
            // textBoxPriceUnit
            // 
            resources.ApplyResources(this.textBoxPriceUnit, "textBoxPriceUnit");
            this.textBoxPriceUnit.Name = "textBoxPriceUnit";
            // 
            // AddSupp
            // 
            this.AddSupp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.AddSupp, "AddSupp");
            this.AddSupp.Name = "AddSupp";
            this.AddSupp.UseVisualStyleBackColor = true;
            this.AddSupp.Click += new System.EventHandler(this.AddSupp_Click);
            // 
            // traidingCompanyDataSet1
            // 
            this.traidingCompanyDataSet1.DataSetName = "TraidingCompanyDataSet1";
            this.traidingCompanyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.traidingCompanyDataSet1;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxIdCategory
            // 
            this.comboBoxIdCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource2, "ID_Category", true));
            this.comboBoxIdCategory.DataSource = this.categoryBindingSource2;
            this.comboBoxIdCategory.DisplayMember = "CategoryName";
            this.comboBoxIdCategory.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxIdCategory, "comboBoxIdCategory");
            this.comboBoxIdCategory.Name = "comboBoxIdCategory";
            this.comboBoxIdCategory.ValueMember = "ID_Category";
            // 
            // categoryBindingSource2
            // 
            this.categoryBindingSource2.DataMember = "Category";
            this.categoryBindingSource2.DataSource = this.traidingCompanyDataSet6;
            // 
            // traidingCompanyDataSet6
            // 
            this.traidingCompanyDataSet6.DataSetName = "TraidingCompanyDataSet6";
            this.traidingCompanyDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.traidingCompanyDataSet1;
            // 
            // comboBoxIdPerson
            // 
            this.comboBoxIdPerson.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personBindingSource3, "ID_Person", true));
            this.comboBoxIdPerson.DataSource = this.personBindingSource3;
            this.comboBoxIdPerson.DisplayMember = "Login";
            this.comboBoxIdPerson.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxIdPerson, "comboBoxIdPerson");
            this.comboBoxIdPerson.Name = "comboBoxIdPerson";
            this.comboBoxIdPerson.ValueMember = "ID_Person";
            // 
            // personBindingSource3
            // 
            this.personBindingSource3.DataMember = "Person";
            this.personBindingSource3.DataSource = this.traidingCompanyDataSet5;
            // 
            // traidingCompanyDataSet5
            // 
            this.traidingCompanyDataSet5.DataSetName = "TraidingCompanyDataSet5";
            this.traidingCompanyDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataMember = "Person";
            this.personBindingSource1.DataSource = this.traidingCompanyDataSet3;
            // 
            // traidingCompanyDataSet3
            // 
            this.traidingCompanyDataSet3.DataSetName = "TraidingCompanyDataSet3";
            this.traidingCompanyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // traidingCompanyDataSet2
            // 
            this.traidingCompanyDataSet2.DataSetName = "TraidingCompanyDataSet2";
            this.traidingCompanyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.traidingCompanyDataSet2;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // personTableAdapter1
            // 
            this.personTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // personBindingSource2
            // 
            this.personBindingSource2.DataMember = "Person";
            this.personBindingSource2.DataSource = this.traidingCompanyDataSet3;
            // 
            // personTableAdapter2
            // 
            this.personTableAdapter2.ClearBeforeFill = true;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddSupply
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxIdPerson);
            this.Controls.Add(this.comboBoxIdCategory);
            this.Controls.Add(this.AddSupp);
            this.Controls.Add(this.textBoxPriceUnit);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxNameGoods);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSupply";
            this.Load += new System.EventHandler(this.AddSupply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traidingCompanyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNameGoods;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxPriceUnit;
        private System.Windows.Forms.Button AddSupp;
        private TraidingCompanyDataSet1 traidingCompanyDataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private TraidingCompanyDataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxIdCategory;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxIdPerson;
        private TraidingCompanyDataSet2 traidingCompanyDataSet2;
        private System.Windows.Forms.BindingSource personBindingSource;
        private TraidingCompanyDataSet2TableAdapters.PersonTableAdapter personTableAdapter;
        private TraidingCompanyDataSet3 traidingCompanyDataSet3;
        private System.Windows.Forms.BindingSource personBindingSource1;
        private TraidingCompanyDataSet3TableAdapters.PersonTableAdapter personTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource personBindingSource2;
        private TraidingCompanyDataSet5 traidingCompanyDataSet5;
        private System.Windows.Forms.BindingSource personBindingSource3;
        private TraidingCompanyDataSet5TableAdapters.PersonTableAdapter personTableAdapter2;
        private TraidingCompanyDataSet6 traidingCompanyDataSet6;
        private System.Windows.Forms.BindingSource categoryBindingSource2;
        private TraidingCompanyDataSet6TableAdapters.CategoryTableAdapter categoryTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}