using BusinessLogic.Concrete;
using DAL.ADO;
using DTO;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class Registration : Form
    {
        static string connStr = ConfigurationManager.ConnectionStrings["TraidingCompany"].ConnectionString;
        static public PersonDAL pd = new PersonDAL(connStr);
        public AuthManager _authManager = new AuthManager(pd);

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'traidingCompanyDataSet4.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.traidingCompanyDataSet4.Roles);
            // TODO: This line of code loads data into the 'traidingCompanyDataSet4.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.traidingCompanyDataSet4.Roles);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SupplyList g = new SupplyList();
            int role = Convert.ToInt32(comboBox1.SelectedValue);
            string firstNam = textBoxFirst.Text;
            string ltNam = textBoxLast.Text;
            string login = textBoxLog.Text;
            byte[] pass = Convert.FromBase64String(textBoxPass.Text);

            var personIdentical = _authManager.GetPersons().SingleOrDefault(x => x.Login == login);

            if(personIdentical != null)
            { 
                MessageBox.Show("ERROR!\n Change login!");
            }
            else
            {
                PersonDTO person = new PersonDTO()
                {
                    ID_Role = role,
                    FirstName = firstNam,
                    LastName = ltNam,
                    Login = login,
                    Password = pass
                };

                _authManager.CreatPerson(person);

                this.Close();
            }
        }
    }
}
