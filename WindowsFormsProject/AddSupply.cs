using BusinessLogic.Concrete;
using DAL.ADO;
using DTO;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class AddSupply : Form
    {
        static string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;
        static public SupplyDAL sp = new SupplyDAL(connStr);
        static public RolesDAL rl = new RolesDAL(connStr);
        static public CategoryDAL ctg = new CategoryDAL(connStr);
        static public PersonDAL pr = new PersonDAL(connStr);
        public SupplyManager supplyManager = new SupplyManager(ctg, pr, rl, sp);

        public AddSupply()
        {
            InitializeComponent();
        }

        private void AddSupp_Click(object sender, EventArgs e)
        {
            SupplyList g = new SupplyList();
            int cat = Convert.ToInt32(comboBoxIdCategory.SelectedValue);
            int pers = Convert.ToInt32(comboBoxIdPerson.SelectedValue);
            string nameg = textBoxNameGoods.Text;
            int num = Convert.ToInt32(textBoxNumber.Text);
            int prun = Convert.ToInt32(textBoxPriceUnit.Text);

            SupplyDTO sup = new SupplyDTO()
            {
                ID_Category = cat,
                ID_Person = pers,
                NameGoods = nameg,
                Number = num,
                PriceUnit = prun
            };

            supplyManager.AddSupply(sup);

            SupplyList dv = new SupplyList();
            BindingSource bs = new BindingSource();
            bs.DataSource = supplyManager.GetListOfSupply();
            dv.dataGridView1.DataSource = bs;
            dv.dataGridView1.Refresh();

            this.Close();
        }

        public void RefreshGrid()
        {
            SupplyList dv = new SupplyList();
            BindingSource bs = new BindingSource();
            bs.DataSource = supplyManager.GetListOfSupply();
            dv.dataGridView1.DataSource = bs;
            dv.dataGridView1.Refresh();
        }

        private void AddSupply_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'traidingCompanyDataSet6.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.traidingCompanyDataSet6.Category);
            // TODO: This line of code loads data into the 'traidingCompanyDataSet5.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter2.Fill(this.traidingCompanyDataSet5.Person);
            // TODO: This line of code loads data into the 'traidingCompanyDataSet3.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter1.Fill(this.traidingCompanyDataSet3.Person);
            // TODO: This line of code loads data into the 'traidingCompanyDataSet2.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.traidingCompanyDataSet2.Person);
            // TODO: This line of code loads data into the 'traidingCompanyDataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.traidingCompanyDataSet1.Category);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personTableAdapter1.FillBy(this.traidingCompanyDataSet3.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
