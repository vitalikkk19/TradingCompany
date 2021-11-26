using BusinessLogic.Concrete;
using DAL.ADO;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class SupplyList : Form
    {
        static string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;
        static public SupplyDAL sp = new SupplyDAL(connStr);
        static public RolesDAL rl = new RolesDAL(connStr);
        static public CategoryDAL ctg = new CategoryDAL(connStr);
        static public PersonDAL pr = new PersonDAL(connStr);
        public SupplyManager supplyManager = new SupplyManager(ctg,pr,rl,sp);

        public SupplyList()
        {
            InitializeComponent();  
        }

        private void SupplyList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'traidingCompanyDataSet7.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.traidingCompanyDataSet7.Category);
            // TODO: This line of code loads data into the 'traidingCompanyDataSet.Supply' table. You can move, or remove it, as needed.
            this.supplyTableAdapter.Fill(this.traidingCompanyDataSet.Supply);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm b = new LoginForm();
            this.Hide();
            b.Show();
        }

        private void DeleteSuppBt_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            supplyManager.DeleteSupply(id);
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = supplyManager.GetListOfSupply();
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }


        private void AddSupply_Click(object sender, EventArgs e)
        {
            AddSupply d = new AddSupply();
            d.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = supplyManager.GetSort();
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            int id = Convert.ToInt32(comboBoxCategorySearch.SelectedValue);
            bs.DataSource = supplyManager.SearchGoodsByCategory(id);
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

        private void buttonCencelSearch_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm b = new LoginForm();
            this.Hide();
            b.Show();
        }
    }
}
